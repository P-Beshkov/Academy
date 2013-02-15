//04. Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the 
//current directory. Find in Google how to download files in C#. Be sure 
//to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient downloader = new WebClient();
        try
        {
            downloader.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "downloads.jpg");
        }
        finally
        {
            downloader.Dispose();
        }
    }
}