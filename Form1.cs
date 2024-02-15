using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PagWeb
{
    public partial class Form1 : Form
    {
        string nombreArchivo = @"E:\Progra3\Progrmas\PagWeb\bin\Debug\Historial.txt";
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }   

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
            comboBoxHistorial.Width = addressBar.Width;
            comboBoxHistorial.Left = addressBar.Left;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardar(string nombreArchivo, string texto)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }
        private void Leer()
        {
            string nombreArchivo = @"E:\Progra3\Progrmas\PagWeb\bin\Debug\Archivo.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string textoLeido = reader.ReadLine();
                comboBoxHistorial.Items.Add(textoLeido);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Leer();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string url = addressBar.Text.Trim();

            if (!string.IsNullOrEmpty(url))
            {
                // Escapar los caracteres especiales para formar el término de búsqueda adecuadamente
                url  = Uri.EscapeDataString(url);

                // Construir la URL de búsqueda usando el término ingresado
                string searchUrl = "https://www.google.com/search?q=" + url;

                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(searchUrl);
                }
            }
            Guardar("archivo.txt", url);
            Leer();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoBack();
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoForward();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
