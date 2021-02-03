using System;
using PassBook.Generator;

namespace PassBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // To generate a pass, start by declaring a PassGenerator
            PassGenerator generator = new PassGenerator();

            // I don't think he was making a coupon
            request.PassTypeIdentifier = "pass.com.mgs.sdmpass"; // I may have to change this to follow the guide
            request.TeamIdentifier = "354UWT7ZK9";
            request.SerialNumber = "121212"; // wot, did I ever get one of these
            request.Description = "My first pass";
            request.OrganizationName = "Tomas McGuinness";
            request.LogoText = "My Pass";

            // byte[] certData = <the contents of the certificate>; // e.g. File.ReadAllBytes(@"C:\path\to\your\certificate");
            // request.Certificate = certData;
            // request.CertificatePassword = "abc123"; // The password for the certificate's private key.

            // assign certData to the path of the wwdr certificateadadfdsafdfsa
            //var certData =  <the contents of the WWDR certificate>; // e.g. File.ReadAllBytes(@"C:\path\to\the\apple\wwdr\certificate");
            request.AppleWWDRCACertificate = certData;

            // Console.WriteLine("Hello World!");
        }
    }
}
