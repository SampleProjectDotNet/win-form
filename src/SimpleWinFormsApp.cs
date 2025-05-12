using System;
using System.Windows.Forms;

namespace win_form
{
    class SimpleWinFormsApp
    {
        [STAThread]
        static void Main()
        {
            // Configurações básicas da aplicação
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Criação do formulário
            Form form = new Form
            {
                Text = "Aplicação Simples",
                Width = 300,
                Height = 200
            };

            // Criação do botão
            Button btnClickMe = new Button
            {
                Text = "Clique aqui",
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(100, 30)
            };

            // Criação do rótulo
            Label lblMessage = new Label
            {
                Location = new System.Drawing.Point(100, 100),
                AutoSize = true
            };

            // Evento de clique do botão
            btnClickMe.Click += (sender, e) => lblMessage.Text = "Olá, mundo!";

            // Adiciona os controles ao formulário
            form.Controls.Add(btnClickMe);
            form.Controls.Add(lblMessage);

            // Executa a aplicação
            Application.Run(form);
        }
    }
}