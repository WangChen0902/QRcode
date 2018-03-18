using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.QrCodeNet.Encoding;

namespace QRcode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("请输入文本(小于100个字符):");
            string sampleText = Console.ReadLine();
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(sampleText);
            if (sampleText.Length > 100)
            {
                Console.WriteLine("提示：文本信息过长！");
            }
            else
            {
                for (int j = 0; j < qrCode.Matrix.Width; j++)
                {
                    for (int i = 0; i < qrCode.Matrix.Width; i++)
                    {

                        char charToPrint = qrCode.Matrix[i, j] ? '　' : '■';
                        Console.Write(charToPrint);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("按任意键退出：");
                Console.ReadKey();
            }
            
        }
    }
}
