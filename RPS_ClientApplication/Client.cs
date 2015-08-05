using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace RPS_ClientApplication
{
    public partial class Client : Form
    {
        //Declare Variables 
        Socket m_ClientSocket;
        System.Net.IPEndPoint m_remoteEndPoint;
        private static System.Windows.Forms.Timer m_CommunicationActivity_Timer;
        string plyrMove;
        string plyrUser;
        int opHealth;
        int health;

        public Client()
        {
            InitializeComponent();
            //From the TCP client sample code
            m_CommunicationActivity_Timer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            m_CommunicationActivity_Timer.Tick += new EventHandler(OnTimedEvent_PeriodicCommunicationActivityCheck); // Set event handler method for timer
            m_CommunicationActivity_Timer.Interval = 100;  // Timer interval is 1/10 second
            m_CommunicationActivity_Timer.Enabled = false;
            string szLocalIPAddress = GetLocalIPAddress_AsString(); // Get local IP address as a default value
            IP_TB.Text = szLocalIPAddress;
            portTB.Text = "8004"; //Set default port number
            //Disable buttons
            strtBtn.Enabled = false;
            confirmBtn.Enabled = false;
            disconnectBtn.Enabled = false;
            rockBtn.Enabled = false;
            scissorBtn.Enabled = false;
            paperBtn.Enabled = false;
            movBtn.Enabled = false;
        }

        //ConfirmBtn used to submit the username chosen by the player
        private void confirmBtn_Click(object sender, EventArgs e)
        {
                try
                {
                    //Send username to server
                    String szData = userTB.Text;
                    plyrUser = userTB.Text;
                    if (szData.Contains(" "))
                    {
                        logTB.AppendText("No Spaces!" + Environment.NewLine);
                    }
                    else if (String.IsNullOrEmpty(userTB.Text))
                    {

                    }
                    else
                    {
                        /*Attach the word "User: " to the username chosen by player to differentiate 
                        the message from other messages sent to the server*/
                        byte[] byData = System.Text.Encoding.ASCII.GetBytes("User: " + szData);
                        m_ClientSocket.Send(byData, SocketFlags.None);
                        strtBtn.Enabled = true;
                        userTB.Enabled = false;
                        confirmBtn.Enabled = false;
                        disconnectBtn.Enabled = true;
                    }
                }
                catch // Silently handle any exceptions
                {
                }
        }

        //From samepl code
        //ConnectBtn used to establish the connection to the server
        private void connectBtn_Click(object sender, EventArgs e)
        {
                // Connect the Socket with a remote endpoint
                try
                {
                    // Create the socket, for TCP use
                    m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    m_ClientSocket.Blocking = true; // Socket operates in Blocking mode initially
                }
                catch // Handle any exceptions
                {
                    Close_Socket_and_Exit();
                }
                try
                {
                    // Get the IP address from the appropriate text box
                    String szIPAddress = IP_TB.Text;
                    System.Net.IPAddress DestinationIPAddress = System.Net.IPAddress.Parse(szIPAddress);

                    // Get the Port number from the appropriate text box
                    String szPort = portTB.Text;
                    int iPort = System.Convert.ToInt16(szPort, 10);

                    // Combine Address and Port to create an Endpoint
                    m_remoteEndPoint = new System.Net.IPEndPoint(DestinationIPAddress, iPort);
                    m_ClientSocket.Connect(m_remoteEndPoint);
                    m_ClientSocket.Blocking = false;    // Socket is now switched to Non-Blocking mode for send/ receive activities
                    connectBtn.Text = "Connected";
                    connectBtn.Enabled = false;
                    IP_TB.Enabled = false;
                    portTB.Enabled = false;
                    disconnectBtn.Enabled = true;
                    confirmBtn.Enabled = true;
                    m_CommunicationActivity_Timer.Start();  // Start the timer to perform periodic checking for received messages   
                }
                catch // Catch all exceptions
                {   // If an exception occurs, display an error message
                    logTB.AppendText("(Connect attempt failed)" + Environment.NewLine + "Retry Connect" + Environment.NewLine);
                }
        }

        //Code from sample code
        //Used to securly close the connection to the server
        private void Close_Socket_and_Exit()
        {
            try
            {
                m_ClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch // Silently handle any exceptions
            {
            }
            try
            {
                m_ClientSocket.Close();
            }
            catch // Silently handle any exceptions
            {
            }
            this.Close();
        }

        //Code from the sample code
        //This is used to find the local IP address and then store it in a string
        private string GetLocalIPAddress_AsString()
        {
            string szHost = Dns.GetHostName();
            string szLocalIPaddress = "127.0.0.1";  // Default is local loopback address
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in IPHost.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork) // Match only the IPv4 address
                {
                    szLocalIPaddress = IP.ToString();
                    break;
                }
            } return szLocalIPaddress;
        }

        //Code from sample code
        /*disconnectBtn is used to disconnect the client from the server
         This also disables & disables certain buttons from the client UI*/
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String szData = "QuitConnection"; // Special code to signal 'close connection' to the server
                // This ensures that the server is aware the Client wants to close the connection
                // (TCP should otherwise automatically detect disconnection, but this approach ensures a clean disconnect)
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                m_ClientSocket.Send(byData, SocketFlags.None);
                m_ClientSocket.Shutdown(SocketShutdown.Both);
                m_ClientSocket.Close();
                disconnectBtn.Enabled = false;
                disconnectBtn.Text = "Connection Closed";
                connectBtn.Enabled = true;
                IP_TB.Enabled = true;
                portTB.Enabled = true;
                connectBtn.Text = "Connect";
                logTB.AppendText ("" + Environment.NewLine);
                strtBtn.Enabled = false;
                userTB.Enabled = true;
            }
            catch // Silently handle any exceptions
            {
            }
        }

        /*Sendbtn used to send "chat messages" to the server 
         Also adds the key word 'chatL' to differentiate the message from other messages*/
        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String szData = messageTB.Text;
                if (String.IsNullOrEmpty(messageTB.Text))
                {

                }
                else
                {
                    byte[] byData = System.Text.Encoding.ASCII.GetBytes("chatL " + userTB.Text + ": " + szData);
                    m_ClientSocket.Send(byData, SocketFlags.None);
                    messageTB.Text = "";
                }
            }
            catch // Silently handle any exceptions
            {
            }
        }

        //Code from sameple code but has many additional if statments added
        //This continuously checks for messages received
        private void OnTimedEvent_PeriodicCommunicationActivityCheck(Object myObject, EventArgs myEventArgs)
        {   // Periodic check whether a message has been received    
            try
            {
                EndPoint RemoteEndPoint = (EndPoint)m_remoteEndPoint;
                byte[] ReceiveBuffer = new byte[1024];
                int iReceiveByteCount;
                iReceiveByteCount = m_ClientSocket.ReceiveFrom(ReceiveBuffer, ref RemoteEndPoint);
                string szReceivedMessage;

                if (0 < iReceiveByteCount)
                {   //Stores the received message from the server 
                    szReceivedMessage = Encoding.ASCII.GetString(ReceiveBuffer, 0, iReceiveByteCount);
                    
                    /*If the received message contains the following word Player has won
                    This also does the calculation to the health points*/
                    if (szReceivedMessage == "You Won by Rock")
                    {
                        opHealth = opHealth - 20;
                        oppHealth.Text = opHealth.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        //Call checkwin method to see if player has won/lost (player/opponent health has reached 0)
                        checkWin();
                    }
                    if (szReceivedMessage == "You Won by Scissors")
                    {
                        opHealth = opHealth - 15;
                        oppHealth.Text = opHealth.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        checkWin();
                    }
                    if (szReceivedMessage == "You Won by Paper")
                    {
                        opHealth = opHealth - 10;
                        oppHealth.Text = opHealth.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        checkWin();
                    }

                    /*If the received message contains the following word Player has lost
                    This also does the calculation to the health points*/
                    if (szReceivedMessage == "You Lost by Rock")
                    {
                        health = health - 20;
                        plyrHealth.Text = health.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        //Call checkwin method to see if player has won/lost (player/opponent health has reached 0)
                        checkWin();
                    }
                    if (szReceivedMessage == "You Lost by Scissors")
                    {
                        health = health - 15;
                        plyrHealth.Text = health.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        checkWin();
                    }
                    if (szReceivedMessage == "You Lost by Paper")
                    {
                        health = health - 10;
                        plyrHealth.Text = health.ToString();
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        checkWin();
                    }
                    /*If the received message contains the word "Draw" Player has drawed*/
                    if (szReceivedMessage == "Draw")
                    {
                        logTB.AppendText("Draw" + Environment.NewLine);
                        rockBtn.Enabled = true;
                        paperBtn.Enabled = true;
                        scissorBtn.Enabled = true;
                        movBtn.Enabled = true;
                        checkWin();
                    }

                    //if the recieved message contains the key word CDecline, reset all buttons to states pre-match
                    //This is to decline a match invite sent by a client
                    else if (szReceivedMessage.Contains("CDecline"))
                    {
                        szReceivedMessage = Encoding.ASCII.GetString(ReceiveBuffer, 0, iReceiveByteCount);
                        /*replace the "CDecline" from the receieved message to an 
                        appropriate message for the system log on the client UI*/
                        szReceivedMessage = szReceivedMessage.Replace("CDecline", "Match has been declined");
                        logTB.AppendText(szReceivedMessage + Environment.NewLine);
                        oppHealth.Text = "";
                        plyrHealth.Text = "";
                        strtBtn.Enabled = true;
                        rockBtn.Enabled = false;
                        scissorBtn.Enabled = false;
                        paperBtn.Enabled = false;
                        movBtn.Enabled = false;
                    }

                    /*if the recieved message contains the key word chatL, remove the "chatL" and add
                    the message to the chatLog textbox*/
                    else if (szReceivedMessage.Contains("chatL"))
                    {
                        szReceivedMessage = Encoding.ASCII.GetString(ReceiveBuffer, 0, iReceiveByteCount);
                        szReceivedMessage = szReceivedMessage.Replace("chatL ", "");
                        chatLog.AppendText(szReceivedMessage + Environment.NewLine);
                    }
                    
                    //This if statement is used to start the match
                    /*if the recieved message contains the key word CSend, display a message box
                     asking the user if they accept the invite, if user chooses 'yes' then the match starts
                     if user chooses 'No' send a message to the server containing the key word CDecline*/
                    else if (szReceivedMessage.Contains("CSend"))
                    {
                        szReceivedMessage = szReceivedMessage.Replace("CSend", "Invite send");
                        if (MessageBox.Show("Game Start?", "Rock, Paper, Scissors!", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            try
                            {
                                String szData = "CDecline";
                                byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                                m_ClientSocket.Send(byData, SocketFlags.None);
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            //This sets everything up for the game
                            opHealth = 100;
                            health = 100;
                            oppHealth.Text = opHealth.ToString();
                            plyrHealth.Text = health.ToString();
                            strtBtn.Enabled = false;
                            rockBtn.Enabled = true;
                            scissorBtn.Enabled = true;
                            paperBtn.Enabled = true;
                            movBtn.Enabled = true;
                            logTB.AppendText("Match has started" + Environment.NewLine);
                        }
                    }
                    //Any other messages received are added to the system log 
                    else
                    {
                        logTB.AppendText(szReceivedMessage + Environment.NewLine);
                    }
                }
            }
            catch // Silently handle any exceptions
            {
            }
        }

        private void messageTB_KeyDown(object sender, KeyEventArgs e)
        {

        }

        //Used to clear the system log
        private void clearBtn_Click(object sender, EventArgs e)
        {
            logTB.Text = "";
        }

        /*StrtBtn first ask the user to confirm if they want to send an invite
         if user confirms, an invite is sent to both players*/
        private void strtBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Send Invite?", "Rock, Paper, Scissors!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                strtBtn.Enabled = false;
                
                try
                {
                    String szData = "CSend";
                    byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                    m_ClientSocket.Send(byData, SocketFlags.None);
                }
                catch
                {
                }
            } 
            else 
            {
            }          
        }

        //Checkwin method used to see if player/opponent health has reached 0
        private void checkWin()
        {
            if (health <= 0)
            {
                MessageBox.Show("You Lost", "You Lost the game", MessageBoxButtons.OK);
                endGame();
            }
            if (opHealth <= 0)
            {
                MessageBox.Show("You Won!", "You Won the game", MessageBoxButtons.OK);
                endGame();
            }
        }

        //endGame method disables certain buttons
        private void endGame()
        {
            strtBtn.Enabled = true;
            rockBtn.Enabled = false;
            scissorBtn.Enabled = false;
            paperBtn.Enabled = false;
            movBtn.Enabled = false;
        }

        private void userLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //movBtn used to send the players move to the server
        private void movBtn_Click(object sender, EventArgs e)
        {  
            try
            {
                String szData = plyrUser + " " + plyrMove;
                if (String.IsNullOrEmpty(plyrMove))
                {
                    logTB.AppendText("Please select move" + Environment.NewLine);
                }
                else
                {
                    byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                    m_ClientSocket.Send(byData, SocketFlags.None);
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;
                    movBtn.Enabled = false;
                }
            }
            catch // Silently handle any exceptions
            {
            }
        }

        //rockBtn stores the word "Rock" in the variable plyrMove
        private void rockBtn_Click(object sender, EventArgs e)
        {
            plyrMove = "Rock";
        }

        //paperbtn stores the word "Paper" in the variable plyrMove
        private void paperBtn_Click(object sender, EventArgs e)
        {
            plyrMove = "Paper";
        }

        //scissorsBtn stores the word "Scissors" in the variable plyrMove
        private void scissorBtn_Click(object sender, EventArgs e)
        {
            plyrMove = "Scissors";
        }

        //this is used to clear the chat log
        private void button1_Click(object sender, EventArgs e)
        {
            chatLog.Text = "";
        }    
    }
}