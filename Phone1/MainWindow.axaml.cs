using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Net.Http.Headers;

namespace Phone1;

public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    Buuton.Click += Buuton_Click;
  }

  private void Buuton_Click(object? sender, RoutedEventArgs e)
  {
    //1
    if (a1.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(0";
    }
    if (a2.IsChecked == true && a1.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(1";
    }
    if (a3.IsChecked == true && a2.IsChecked == false && a1.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(2";
    }
    if (a4.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a1.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(3";
    }
    if (a5.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a1.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(4";
    }
    if (a6.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a1.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(5";
    }
    if (a7.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a1.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(6";
    }
    if (a8.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a1.IsChecked == false && a9.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(7";
    }
    if (a9.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a1.IsChecked == false && a10.IsChecked == false)
    {
      message.Text = "(8";
    }
    if (a10.IsChecked == true && a2.IsChecked == false && a3.IsChecked == false && a4.IsChecked == false && a5.IsChecked == false && a6.IsChecked == false && a7.IsChecked == false && a8.IsChecked == false && a9.IsChecked == false && a1.IsChecked == false)
    {
      message.Text = "(9";
    }
    //2
    if (a11.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a12.IsChecked == true && a11.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a13.IsChecked == true && a12.IsChecked == false && a11.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a14.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a11.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a15.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a11.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a16.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a11.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a17.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a11.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a18.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a11.IsChecked == false && a19.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a19.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a11.IsChecked == false && a20.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a20.IsChecked == true && a12.IsChecked == false && a13.IsChecked == false && a14.IsChecked == false && a15.IsChecked == false && a16.IsChecked == false && a17.IsChecked == false && a18.IsChecked == false && a19.IsChecked == false && a11.IsChecked == false)
    {
      message.Text += "9";
    }
    //3
    if (a21.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "0)";
    }
    if (a22.IsChecked == true && a21.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "1)";
    }
    if (a23.IsChecked == true && a22.IsChecked == false && a21.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "2)";
    }
    if (a24.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a21.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "3)";
    }
    if (a25.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a21.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "4)";
    }
    if (a26.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a21.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "5)";
    }
    if (a27.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a21.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "6)";
    }
    if (a28.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a21.IsChecked == false && a29.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "7)";
    }
    if (a29.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a21.IsChecked == false && a30.IsChecked == false)
    {
      message.Text += "8)";
    }
    if (a30.IsChecked == true && a22.IsChecked == false && a23.IsChecked == false && a24.IsChecked == false && a25.IsChecked == false && a26.IsChecked == false && a27.IsChecked == false && a28.IsChecked == false && a29.IsChecked == false && a21.IsChecked == false)
    {
      message.Text += "9)";
    }
    //4
    if (a31.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a32.IsChecked == true && a31.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a33.IsChecked == true && a32.IsChecked == false && a31.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a34.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a31.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a35.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a31.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a36.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a31.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a37.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a31.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a38.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a31.IsChecked == false && a39.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a39.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a31.IsChecked == false && a40.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a40.IsChecked == true && a32.IsChecked == false && a33.IsChecked == false && a34.IsChecked == false && a35.IsChecked == false && a36.IsChecked == false && a37.IsChecked == false && a38.IsChecked == false && a39.IsChecked == false && a31.IsChecked == false)
    {
      message.Text += "9";
    }
    //5
    if (a41.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a42.IsChecked == true && a41.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a43.IsChecked == true && a42.IsChecked == false && a41.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a44.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a41.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a45.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a41.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a46.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a41.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a47.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a41.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a48.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a41.IsChecked == false && a49.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a49.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a41.IsChecked == false && a50.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a50.IsChecked == true && a42.IsChecked == false && a43.IsChecked == false && a44.IsChecked == false && a45.IsChecked == false && a46.IsChecked == false && a47.IsChecked == false && a48.IsChecked == false && a49.IsChecked == false && a41.IsChecked == false)
    {
      message.Text += "9";
    }
    //6
    if (a51.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "0-";
    }
    if (a52.IsChecked == true && a51.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "1-";
    }
    if (a53.IsChecked == true && a52.IsChecked == false && a51.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "2-";
    }
    if (a54.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a51.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "3-";
    }
    if (a55.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a51.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "4-";
    }
    if (a56.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a51.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "5-";
    }
    if (a57.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a51.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "6-";
    }
    if (a58.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a51.IsChecked == false && a59.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "7-";
    }
    if (a59.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a51.IsChecked == false && a60.IsChecked == false)
    {
      message.Text += "8-";
    }
    if (a60.IsChecked == true && a52.IsChecked == false && a53.IsChecked == false && a54.IsChecked == false && a55.IsChecked == false && a56.IsChecked == false && a57.IsChecked == false && a58.IsChecked == false && a59.IsChecked == false && a51.IsChecked == false)
    {
      message.Text += "9-";
    }
    //7
    if (a61.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a62.IsChecked == true && a61.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a63.IsChecked == true && a62.IsChecked == false && a61.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a64.IsChecked == true && a61.IsChecked == false && a63.IsChecked == false && a61.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a65.IsChecked == true && a62.IsChecked == false && a61.IsChecked == false && a64.IsChecked == false && a61.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a66.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a61.IsChecked == false && a65.IsChecked == false && a61.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a67.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a61.IsChecked == false && a66.IsChecked == false && a61.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a68.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a61.IsChecked == false && a69.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a69.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a61.IsChecked == false && a70.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a70.IsChecked == true && a62.IsChecked == false && a63.IsChecked == false && a64.IsChecked == false && a65.IsChecked == false && a66.IsChecked == false && a67.IsChecked == false && a68.IsChecked == false && a69.IsChecked == false && a61.IsChecked == false)
    {
      message.Text += "9";
    }
    //8
    if (a71.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a72.IsChecked == true && a71.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a73.IsChecked == true && a72.IsChecked == false && a71.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a74.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a71.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a75.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a71.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a76.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a71.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a77.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a71.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a78.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a71.IsChecked == false && a79.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a79.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a71.IsChecked == false && a80.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a80.IsChecked == true && a72.IsChecked == false && a73.IsChecked == false && a74.IsChecked == false && a75.IsChecked == false && a76.IsChecked == false && a77.IsChecked == false && a78.IsChecked == false && a79.IsChecked == false && a71.IsChecked == false)
    {
      message.Text += "9";
    }
    //9
    if (a81.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a82.IsChecked == true && a81.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a83.IsChecked == true && a82.IsChecked == false && a81.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a84.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a81.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a85.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a81.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a86.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a81.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a87.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a81.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a88.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a81.IsChecked == false && a89.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a89.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a81.IsChecked == false && a90.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a90.IsChecked == true && a82.IsChecked == false && a83.IsChecked == false && a84.IsChecked == false && a85.IsChecked == false && a86.IsChecked == false && a87.IsChecked == false && a88.IsChecked == false && a89.IsChecked == false && a81.IsChecked == false)
    {
      message.Text += "9";
    }
    //10
    if (a91.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "0";
    }
    if (a92.IsChecked == true && a91.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "1";
    }
    if (a93.IsChecked == true && a92.IsChecked == false && a91.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "2";
    }
    if (a94.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a91.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "3";
    }
    if (a95.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a91.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "4";
    }
    if (a96.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a91.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "5";
    }
    if (a97.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a91.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "6";
    }
    if (a98.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a91.IsChecked == false && a99.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "7";
    }
    if (a99.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a91.IsChecked == false && a100.IsChecked == false)
    {
      message.Text += "8";
    }
    if (a100.IsChecked == true && a92.IsChecked == false && a93.IsChecked == false && a94.IsChecked == false && a95.IsChecked == false && a96.IsChecked == false && a97.IsChecked == false && a98.IsChecked == false && a99.IsChecked == false && a91.IsChecked == false)
    {
      message.Text += "9";
    }
  }
}