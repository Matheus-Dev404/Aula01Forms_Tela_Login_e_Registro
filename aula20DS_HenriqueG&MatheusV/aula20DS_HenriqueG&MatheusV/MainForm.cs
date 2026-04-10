/*
 * Created by SharpDevelop.
 * User: aluno_faculdade
 * Date: 12/03/2026
 * Time: 10:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace aula20DS_HenriqueG_MatheusV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			label1.Parent = this;
		}
		void Label1Click(object sender, EventArgs e)
		{
		
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}

		async void Button1Click(object sender, EventArgs e)
		{
			
			string userDigitado = textBox1.Text;
			string senhaDigitado = textBox2.Text;
			
			if (userDigitado == "" || senhaDigitado == "") {
			MessageBox.Show("Não digitou credenciais!");
			} else {
			string usuario = userDigitado;
			string senha = senhaDigitado;
			
			MessageBox.Show("Cadastrado com sucesso!");
			}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}
