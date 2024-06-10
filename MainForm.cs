/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/10/2024
 * Time: 12:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace linefall
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TO D O: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			g = this.panel1.CreateGraphics();
			panel1.BackColor = Color.Black;
			
		}
		public Graphics g;
		public Graphics gg;
		public bool runningison = false;
		
		public Pen p = new Pen(Color.FromArgb(255,0,0,0),1);
		public Brush b = new SolidBrush(Color.Green);
		public double rad = 180/Math.PI;
		public char[] c = {'X','D','W','Y','U','H','J','K','K','Q','S','Z','U','P','M','N','B','A','C','V','F','G','H','T','R','E','W','X','D','W','Y','U','H','J','K','K','Q','S','Z','U','P','M','N','B','A','C','V','F','G','H','T','R','E','W'};
		public void DESENEAZA(int m, int start, int end)
		{
		
			int j = start+1;
			char d =' ';
			for(int i = start ; i< end; i++)
			{
				d = (char)r.Next(1,256);
				j++;
				//g.DrawString(c[i].ToString(),panel1.Font,b,m,(j)*11);
				g.DrawString(d.ToString(),panel1.Font,b,m,(j)*11);
				//Thread.Sleep(1);
			}
		
		}
		Random r = new Random();
		void Button1Click(object sender, EventArgs e)
		{
			for(int lml = 0 ; lml<100;lml++){
						
						g.Clear(Color.Black);
						
						int pas = 0;
						int pas2 = 0;
						
						for(int i = 0 ; i< c.Length; i++)
						{
							pas =  r.Next(0,c.Length);
							pas2 = pas +r.Next(0,c.Length);
							if(pas2>c.Length){pas2=c.Length;}
							DESENEAZA(i*20,pas,pas2);
							Thread.Sleep(1);
						}
			Thread.Sleep(1);
			}
		}
	}
}
