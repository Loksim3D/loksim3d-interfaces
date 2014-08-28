/*
 * Created by SharpDevelop.
 * User: Alle
 * Date: 29.01.2006
 * Time: 22:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using LoksimControl;
using LoksimUtil;


namespace LoksimClient
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button ButtonAFBUp;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label LabelActKMH;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.Button ButtonSchaltUp;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label LabelSchaltSoll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelHLDruck;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LabelActSimTime;
		private System.Windows.Forms.Button ButtonIndusi;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ButtonHauptSchalter;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label LabelSifa;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label LabelAFBAn;
		private System.Windows.Forms.Label LabelZylDruck;
		private System.Windows.Forms.Button buttonSifa;
		private System.Windows.Forms.Label LabelVMax;
		private System.Windows.Forms.Label LabelAFBV;
		private System.Windows.Forms.Button ButtonAFBDown;
		private System.Windows.Forms.Button ButtonSchaltDown;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button ButtonBremseUp;
		private System.Windows.Forms.Label LabelHauptschalter;
		private System.Windows.Forms.Button ButtonBremseDown;
		private System.Windows.Forms.Button buttonStart;
        private Label label1000Hz;
        private Label label500Hz;
        private Label labelWechselblinken;
        private Label label1000HzSystem;
        private Label label500HzSystem;
        private Label lblZugsicherung;
		private System.Windows.Forms.Label LabelSchaltIst;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			timer1.Interval = 250;
			timer1.Enabled = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		private LoksimControl.ILoksimAutoServer Loksim;
		
		private double ActSpeed;
		private double LokMaxSpeed;
		private double ActSimTime;

		private bool HauptSchalter;
		private bool AnzeigeSifa;

		private double SchaltSoll;
		private double SchaltIst;

		private double HlDruck;
		private double ZylinderDruck;
		private bool AfbStatus;
		private double AfbZiel;
		
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.LabelSchaltIst = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ButtonBremseDown = new System.Windows.Forms.Button();
            this.LabelHauptschalter = new System.Windows.Forms.Label();
            this.ButtonBremseUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonSchaltDown = new System.Windows.Forms.Button();
            this.ButtonAFBDown = new System.Windows.Forms.Button();
            this.LabelAFBV = new System.Windows.Forms.Label();
            this.LabelVMax = new System.Windows.Forms.Label();
            this.buttonSifa = new System.Windows.Forms.Button();
            this.LabelZylDruck = new System.Windows.Forms.Label();
            this.LabelAFBAn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonIndusi = new System.Windows.Forms.Button();
            this.LabelSifa = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelHLDruck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonAFBUp = new System.Windows.Forms.Button();
            this.ButtonHauptSchalter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelActSimTime = new System.Windows.Forms.Label();
            this.LabelActKMH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSchaltSoll = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonSchaltUp = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label1000Hz = new System.Windows.Forms.Label();
            this.label500Hz = new System.Windows.Forms.Label();
            this.labelWechselblinken = new System.Windows.Forms.Label();
            this.label1000HzSystem = new System.Windows.Forms.Label();
            this.label500HzSystem = new System.Windows.Forms.Label();
            this.lblZugsicherung = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSchaltIst
            // 
            this.LabelSchaltIst.AutoSize = true;
            this.LabelSchaltIst.Location = new System.Drawing.Point(248, 16);
            this.LabelSchaltIst.Name = "LabelSchaltIst";
            this.LabelSchaltIst.Size = new System.Drawing.Size(74, 13);
            this.LabelSchaltIst.TabIndex = 5;
            this.LabelSchaltIst.Text = "LabelSchaltIst";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // ButtonBremseDown
            // 
            this.ButtonBremseDown.Location = new System.Drawing.Point(88, 8);
            this.ButtonBremseDown.Name = "ButtonBremseDown";
            this.ButtonBremseDown.Size = new System.Drawing.Size(24, 23);
            this.ButtonBremseDown.TabIndex = 2;
            this.ButtonBremseDown.Text = "-";
            this.ButtonBremseDown.Click += new System.EventHandler(this.ButtonBremseDownClick);
            // 
            // LabelHauptschalter
            // 
            this.LabelHauptschalter.AutoSize = true;
            this.LabelHauptschalter.Location = new System.Drawing.Point(128, 16);
            this.LabelHauptschalter.Name = "LabelHauptschalter";
            this.LabelHauptschalter.Size = new System.Drawing.Size(99, 13);
            this.LabelHauptschalter.TabIndex = 1;
            this.LabelHauptschalter.Text = "LabelHauptschalter";
            // 
            // ButtonBremseUp
            // 
            this.ButtonBremseUp.Location = new System.Drawing.Point(112, 8);
            this.ButtonBremseUp.Name = "ButtonBremseUp";
            this.ButtonBremseUp.Size = new System.Drawing.Size(24, 23);
            this.ButtonBremseUp.TabIndex = 3;
            this.ButtonBremseUp.Text = "+";
            this.ButtonBremseUp.Click += new System.EventHandler(this.ButtonBremseUpClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // ButtonSchaltDown
            // 
            this.ButtonSchaltDown.Location = new System.Drawing.Point(88, 8);
            this.ButtonSchaltDown.Name = "ButtonSchaltDown";
            this.ButtonSchaltDown.Size = new System.Drawing.Size(24, 23);
            this.ButtonSchaltDown.TabIndex = 2;
            this.ButtonSchaltDown.Text = "-";
            this.ButtonSchaltDown.Click += new System.EventHandler(this.ButtonSchaltDownClick);
            // 
            // ButtonAFBDown
            // 
            this.ButtonAFBDown.Location = new System.Drawing.Point(88, 8);
            this.ButtonAFBDown.Name = "ButtonAFBDown";
            this.ButtonAFBDown.Size = new System.Drawing.Size(24, 23);
            this.ButtonAFBDown.TabIndex = 2;
            this.ButtonAFBDown.Text = "-";
            this.ButtonAFBDown.Click += new System.EventHandler(this.ButtonAFBDownClick);
            // 
            // LabelAFBV
            // 
            this.LabelAFBV.AutoSize = true;
            this.LabelAFBV.Location = new System.Drawing.Point(248, 16);
            this.LabelAFBV.Name = "LabelAFBV";
            this.LabelAFBV.Size = new System.Drawing.Size(60, 13);
            this.LabelAFBV.TabIndex = 5;
            this.LabelAFBV.Text = "LabelAFBV";
            // 
            // LabelVMax
            // 
            this.LabelVMax.AutoSize = true;
            this.LabelVMax.Location = new System.Drawing.Point(128, 8);
            this.LabelVMax.Name = "LabelVMax";
            this.LabelVMax.Size = new System.Drawing.Size(60, 13);
            this.LabelVMax.TabIndex = 1;
            this.LabelVMax.Text = "LabelVMax";
            // 
            // buttonSifa
            // 
            this.buttonSifa.Location = new System.Drawing.Point(16, 8);
            this.buttonSifa.Name = "buttonSifa";
            this.buttonSifa.Size = new System.Drawing.Size(96, 23);
            this.buttonSifa.TabIndex = 2;
            this.buttonSifa.Text = "Sifa";
            this.buttonSifa.Click += new System.EventHandler(this.ButtonSifaClick);
            // 
            // LabelZylDruck
            // 
            this.LabelZylDruck.AutoSize = true;
            this.LabelZylDruck.Location = new System.Drawing.Point(248, 16);
            this.LabelZylDruck.Name = "LabelZylDruck";
            this.LabelZylDruck.Size = new System.Drawing.Size(76, 13);
            this.LabelZylDruck.TabIndex = 5;
            this.LabelZylDruck.Text = "LabelZylDruck";
            // 
            // LabelAFBAn
            // 
            this.LabelAFBAn.AutoSize = true;
            this.LabelAFBAn.Location = new System.Drawing.Point(156, 16);
            this.LabelAFBAn.Name = "LabelAFBAn";
            this.LabelAFBAn.Size = new System.Drawing.Size(66, 13);
            this.LabelAFBAn.TabIndex = 4;
            this.LabelAFBAn.Text = "LabelAFBAn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonIndusi);
            this.panel4.Controls.Add(this.buttonSifa);
            this.panel4.Controls.Add(this.LabelSifa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 40);
            this.panel4.TabIndex = 6;
            // 
            // ButtonIndusi
            // 
            this.ButtonIndusi.Location = new System.Drawing.Point(240, 8);
            this.ButtonIndusi.Name = "ButtonIndusi";
            this.ButtonIndusi.Size = new System.Drawing.Size(112, 23);
            this.ButtonIndusi.TabIndex = 3;
            this.ButtonIndusi.Text = "Indusi Wachsam";
            this.ButtonIndusi.Click += new System.EventHandler(this.ButtonIndusiClick);
            // 
            // LabelSifa
            // 
            this.LabelSifa.AutoSize = true;
            this.LabelSifa.Location = new System.Drawing.Point(128, 16);
            this.LabelSifa.Name = "LabelSifa";
            this.LabelSifa.Size = new System.Drawing.Size(51, 13);
            this.LabelSifa.TabIndex = 1;
            this.LabelSifa.Text = "LabelSifa";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LabelZylDruck);
            this.panel6.Controls.Add(this.LabelHLDruck);
            this.panel6.Controls.Add(this.ButtonBremseUp);
            this.panel6.Controls.Add(this.ButtonBremseDown);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 40);
            this.panel6.TabIndex = 8;
            // 
            // LabelHLDruck
            // 
            this.LabelHLDruck.AutoSize = true;
            this.LabelHLDruck.Location = new System.Drawing.Point(156, 16);
            this.LabelHLDruck.Name = "LabelHLDruck";
            this.LabelHLDruck.Size = new System.Drawing.Size(76, 13);
            this.LabelHLDruck.TabIndex = 4;
            this.LabelHLDruck.Text = "LabelHLDruck";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bremse";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.LabelAFBV);
            this.panel7.Controls.Add(this.LabelAFBAn);
            this.panel7.Controls.Add(this.ButtonAFBUp);
            this.panel7.Controls.Add(this.ButtonAFBDown);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 40);
            this.panel7.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "AFB an/aus";
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // ButtonAFBUp
            // 
            this.ButtonAFBUp.Location = new System.Drawing.Point(112, 8);
            this.ButtonAFBUp.Name = "ButtonAFBUp";
            this.ButtonAFBUp.Size = new System.Drawing.Size(24, 23);
            this.ButtonAFBUp.TabIndex = 3;
            this.ButtonAFBUp.Text = "+";
            this.ButtonAFBUp.Click += new System.EventHandler(this.ButtonAFBUpClick);
            // 
            // ButtonHauptSchalter
            // 
            this.ButtonHauptSchalter.Location = new System.Drawing.Point(16, 8);
            this.ButtonHauptSchalter.Name = "ButtonHauptSchalter";
            this.ButtonHauptSchalter.Size = new System.Drawing.Size(96, 23);
            this.ButtonHauptSchalter.TabIndex = 2;
            this.ButtonHauptSchalter.Text = "Hauptschalter";
            this.ButtonHauptSchalter.Click += new System.EventHandler(this.ButtonHauptSchalterClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelActSimTime);
            this.panel2.Controls.Add(this.LabelVMax);
            this.panel2.Controls.Add(this.LabelActKMH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 32);
            this.panel2.TabIndex = 4;
            // 
            // LabelActSimTime
            // 
            this.LabelActSimTime.AutoSize = true;
            this.LabelActSimTime.Location = new System.Drawing.Point(240, 8);
            this.LabelActSimTime.Name = "LabelActSimTime";
            this.LabelActSimTime.Size = new System.Drawing.Size(89, 13);
            this.LabelActSimTime.TabIndex = 2;
            this.LabelActSimTime.Text = "LabelActSimTime";
            // 
            // LabelActKMH
            // 
            this.LabelActKMH.AutoSize = true;
            this.LabelActKMH.Location = new System.Drawing.Point(16, 8);
            this.LabelActKMH.Name = "LabelActKMH";
            this.LabelActKMH.Size = new System.Drawing.Size(73, 13);
            this.LabelActKMH.TabIndex = 0;
            this.LabelActKMH.Text = "LabelActKMH";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonHauptSchalter);
            this.panel3.Controls.Add(this.LabelHauptschalter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 40);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schaltwerk";
            // 
            // LabelSchaltSoll
            // 
            this.LabelSchaltSoll.AutoSize = true;
            this.LabelSchaltSoll.Location = new System.Drawing.Point(156, 16);
            this.LabelSchaltSoll.Name = "LabelSchaltSoll";
            this.LabelSchaltSoll.Size = new System.Drawing.Size(80, 13);
            this.LabelSchaltSoll.TabIndex = 4;
            this.LabelSchaltSoll.Text = "LabelSchaltSoll";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LabelSchaltIst);
            this.panel5.Controls.Add(this.LabelSchaltSoll);
            this.panel5.Controls.Add(this.ButtonSchaltUp);
            this.panel5.Controls.Add(this.ButtonSchaltDown);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 40);
            this.panel5.TabIndex = 7;
            // 
            // ButtonSchaltUp
            // 
            this.ButtonSchaltUp.Location = new System.Drawing.Point(112, 8);
            this.ButtonSchaltUp.Name = "ButtonSchaltUp";
            this.ButtonSchaltUp.Size = new System.Drawing.Size(24, 23);
            this.ButtonSchaltUp.TabIndex = 3;
            this.ButtonSchaltUp.Text = "+";
            this.ButtonSchaltUp.Click += new System.EventHandler(this.ButtonSchaltUpClick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 354);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(376, 22);
            this.statusBar1.TabIndex = 3;
            this.statusBar1.Text = "Status";
            // 
            // label1000Hz
            // 
            this.label1000Hz.AutoSize = true;
            this.label1000Hz.Location = new System.Drawing.Point(8, 292);
            this.label1000Hz.Name = "label1000Hz";
            this.label1000Hz.Size = new System.Drawing.Size(35, 13);
            this.label1000Hz.TabIndex = 10;
            this.label1000Hz.Text = "label2";
            // 
            // label500Hz
            // 
            this.label500Hz.AutoSize = true;
            this.label500Hz.Location = new System.Drawing.Point(101, 292);
            this.label500Hz.Name = "label500Hz";
            this.label500Hz.Size = new System.Drawing.Size(35, 13);
            this.label500Hz.TabIndex = 11;
            this.label500Hz.Text = "label2";
            // 
            // labelWechselblinken
            // 
            this.labelWechselblinken.AutoSize = true;
            this.labelWechselblinken.Location = new System.Drawing.Point(201, 292);
            this.labelWechselblinken.Name = "labelWechselblinken";
            this.labelWechselblinken.Size = new System.Drawing.Size(35, 13);
            this.labelWechselblinken.TabIndex = 12;
            this.labelWechselblinken.Text = "label2";
            // 
            // label1000HzSystem
            // 
            this.label1000HzSystem.AutoSize = true;
            this.label1000HzSystem.Location = new System.Drawing.Point(8, 317);
            this.label1000HzSystem.Name = "label1000HzSystem";
            this.label1000HzSystem.Size = new System.Drawing.Size(0, 13);
            this.label1000HzSystem.TabIndex = 13;
            // 
            // label500HzSystem
            // 
            this.label500HzSystem.AutoSize = true;
            this.label500HzSystem.Location = new System.Drawing.Point(101, 317);
            this.label500HzSystem.Name = "label500HzSystem";
            this.label500HzSystem.Size = new System.Drawing.Size(0, 13);
            this.label500HzSystem.TabIndex = 14;
            // 
            // lblZugsicherung
            // 
            this.lblZugsicherung.AutoSize = true;
            this.lblZugsicherung.Location = new System.Drawing.Point(11, 317);
            this.lblZugsicherung.Name = "lblZugsicherung";
            this.lblZugsicherung.Size = new System.Drawing.Size(35, 13);
            this.lblZugsicherung.TabIndex = 15;
            this.lblZugsicherung.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(376, 376);
            this.Controls.Add(this.lblZugsicherung);
            this.Controls.Add(this.label500HzSystem);
            this.Controls.Add(this.label1000HzSystem);
            this.Controls.Add(this.labelWechselblinken);
            this.Controls.Add(this.label500Hz);
            this.Controls.Add(this.label1000Hz);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		void ButtonStartClick(object sender, System.EventArgs e)
		{
			Loksim = new LoksimControl.LoksimAutoServer();
			
		}

	
		void Timer1Tick(object sender, System.EventArgs e)
		{  
			timer1.Enabled = false;

			if( null != Loksim)
			{
				Loksim.StartWaitForCommands( 500);
				if (Loksim.LoksimIsRunning())
				{
					if (Loksim.SimulationIsRunning())
					{
						statusBar1.Text = "Alles ok";    					
						string Params = "";
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_COMMON_ACTSPEED);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_COMMON_MAXSPEED);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cSIM_COMMON_SIMTIME);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_ANZEIGE_HAUPTSCHALTER);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_ANZEIGE_SIFA);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_INSTRUMENT_SOLLSTUFE);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_INSTRUMENT_ISTSTUFE);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_INSTRUMENT_BREMSDRUCK);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_INSTRUMENT_BREMSZYLINDERDRUCK);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_ANZEIGE_AFB);
						LoksimHelper.AddParam( ref Params, LoksimHelper.cLOK_INSTRUMENT_AFB);

                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_ANZEIGE_INDUSIHZ1000);
                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_ANZEIGE_INDUSIHZ500);
                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_ANZEIGE_INDUSIWECHSELBLINKEN);
                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_SYSTEM_INDUSIHZ1000);
                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_SYSTEM_INDUSIHZ500);
                        LoksimHelper.AddParam(ref Params, LoksimHelper.cLOK_COMMON_ZUGSICHERUNG);
						
						string RetParams = Loksim.GetSimData( Params);          			
						
						ActSpeed = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_COMMON_ACTSPEED);          				
						HauptSchalter = LoksimHelper.GetParamBool( RetParams, LoksimHelper.cLOK_ANZEIGE_HAUPTSCHALTER);          				
						LokMaxSpeed = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_COMMON_MAXSPEED);
						ActSimTime = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cSIM_COMMON_SIMTIME);

						HauptSchalter = LoksimHelper.GetParamBool( RetParams, LoksimHelper.cLOK_ANZEIGE_HAUPTSCHALTER);          				          
						AnzeigeSifa = LoksimHelper.GetParamBool( RetParams, LoksimHelper.cLOK_ANZEIGE_SIFA);

						SchaltSoll = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_INSTRUMENT_SOLLSTUFE);
						SchaltIst = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_INSTRUMENT_ISTSTUFE);

						HlDruck = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_INSTRUMENT_BREMSDRUCK);
						ZylinderDruck = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_INSTRUMENT_BREMSZYLINDERDRUCK);
						AfbStatus = LoksimHelper.GetParamBool( RetParams, LoksimHelper.cLOK_ANZEIGE_AFB);
						AfbZiel = LoksimHelper.GetParamFloat( RetParams, LoksimHelper.cLOK_INSTRUMENT_AFB);

                        label1000Hz.Text = "1000Hz " + LoksimHelper.GetParamBool(RetParams, LoksimHelper.cLOK_ANZEIGE_INDUSIHZ1000);
                        label500Hz.Text = "500Hz " + LoksimHelper.GetParamBool(RetParams, LoksimHelper.cLOK_ANZEIGE_INDUSIHZ500);
                        labelWechselblinken.Text = "Wechselblinken " + LoksimHelper.GetParamFloat(RetParams, LoksimHelper.cLOK_ANZEIGE_INDUSIWECHSELBLINKEN);
                        label1000HzSystem.Text = "S 1000Hz " + LoksimHelper.GetParamBool(RetParams, LoksimHelper.cLOK_SYSTEM_INDUSIHZ1000);
                        label500HzSystem.Text = "S 500Hz " + LoksimHelper.GetParamBool(RetParams, LoksimHelper.cLOK_SYSTEM_INDUSIHZ500);
                        var zs = LoksimHelper.GetParamString(RetParams, LoksimHelper.cLOK_COMMON_ZUGSICHERUNG);
                        lblZugsicherung.Text = "Zugsicherung " + zs;
                        SampleProcessors.ProcessZugsicherung(zs);
					}
					else
					{
						statusBar1.Text = "Simulation läuft nicht oder pausiert";
					}
				}
				else
				{
					statusBar1.Text = "Loksim läuft nicht -> Loksim starten";
				}
				Loksim.StopWaitForCommands();
			}
			else
			{
				statusBar1.Text = "Ole-Server nicht gestartet -> Drücken sie Start";
			}
			
			//und Controls setzten
			if( HauptSchalter)
				LabelHauptschalter.Text = "An";
			else
				LabelHauptschalter.Text = "Aus";

			LabelActKMH.Text = "V: " + ActSpeed.ToString();
			LabelVMax.Text = "Vmax: " + LokMaxSpeed.ToString();
			LabelActSimTime.Text = "ActSimTime: " + ActSimTime.ToString();

			if( AnzeigeSifa)
				LabelSifa.Text = "Lampe AN";
			else
				LabelSifa.Text = "Lampe AUS";

			LabelSchaltSoll.Text = "Soll: " + SchaltSoll.ToString();
			LabelSchaltIst.Text = "Ist: " + SchaltIst.ToString();

			LabelHLDruck.Text = "HLDruck: " + HlDruck.ToString();
			LabelZylDruck.Text = "Zyl.Druck: " + ZylinderDruck.ToString();

			if( AfbStatus)
				LabelAFBAn.Text = "AFB AN";
			else
				LabelAFBAn.Text = "AFB AUS";

			LabelAFBV.Text = "AFB-Ziel: " + AfbZiel.ToString();

			
			timer1.Enabled = true;			
		}
		
		void ButtonHauptSchalterClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_HAUPTSCHALTER);
			}
		}
		void ButtonSifaClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_SIFA);
			}
			
		}
		
		void ButtonIndusiClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_INDUSI);
			}
			
		}
		
		void ButtonSchaltDownClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_STDOWN);
			}
		}
		void ButtonSchaltUpClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_STUP);
			}
			
		}
		
		void ButtonBremseDownClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_BREMSEN1);
			}
			
		}
		
		void ButtonBremseUpClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_BREMSEN7);
			}
			
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_AFB);
			}
			
		}
		
		void ButtonAFBDownClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_STLEFT);
			}
			
		}
		
		void ButtonAFBUpClick(object sender, System.EventArgs e)
		{
			if( null != Loksim)
			{
				Loksim.SendKey( LoksimHelper.KEY_STRIGHT);
			}
			
		}		
	}
}
