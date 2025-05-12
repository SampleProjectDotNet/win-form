using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace win_form.test
{
    [TestClass]
    public class SimpleWinFormsAppTests
    {
        [TestMethod]
        public void Form_ShouldHaveCorrectTitle()
        {
            // Arrange
            Form form = CreateForm();

            // Act
            string formTitle = form.Text;

            // Assert
            Assert.AreEqual("Aplicação Simples", formTitle);
        }

        private Form CreateForm()
        {
            // Simula a criação do formulário no método Main
            Form form = new Form
            {
                Text = "Aplicação Simples",
                Width = 300,
                Height = 200
            };

            Button btnClickMe = new Button
            {
                Text = "Clique aqui",
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(100, 30)
            };

            Label lblMessage = new Label
            {
                Location = new System.Drawing.Point(100, 100),
                AutoSize = true
            };

            btnClickMe.Click += (sender, e) => lblMessage.Text = "Olá, mundo!";

            form.Controls.Add(btnClickMe);
            form.Controls.Add(lblMessage);

            return form;
        }
    }
}