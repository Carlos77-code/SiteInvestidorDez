using SiteInvestidorDez.Core;
using System;
using System.IO;
using System.Reflection.Emit;

namespace SiteInvestidorDez.Page
{
    class ValidaCotaMXRF11Page : Begin
    {
        public void PreencheCampoAcao()
        {
            EscreveTexto("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/span/input[2]", "MXRF11");
        }

        public void ClicaBtnBusca()
        {
            ClicaElemento("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/button");
        }

        public void ValidaResultadoClass()
        {
            ValidaClass("result-text", "MXRF11");
        }

        public void ClicaResultadoBusca()
        {
            ClickElementResult("//*[@id=\'results\']/div/div[2]/div[1]/div");
        }

        public void ValidaBuscaDividendo()
        {
            ValidaDados("//*[@id=\'table-dividends-history\']/tbody/tr[1]/td[1]", "Dividendos");
        }

        public void ValidaResultadoAcoesEDividendos()
        {
            string[] dados =
            {
                "Dividendos", //[0]
                "28/12/2023", //[1]
                "15/01/2024", //[2]
                "0,11000000"  //[3]
            };
            for(int i = 0; i < dados.Length; i++)
            {
                ValidaDados("//*[@id=\'table-dividends-history\']/tbody/tr[1]/td[" + (i + 1) + "]", dados[i]);
                Console.WriteLine(dados[i]);
            }
        }

        public void ValidaMultiplosDividendos()
        {
            string[] cotas = File.ReadAllLines(@"C:\\Users\\Carlos\\Documents\\Github\\SiteInvestidorDez\\DataBase\\cotas.txt");
            /*{
                "MXRF11",
                "BDIV11",
                "BLMG11",
                "EGAF11",
                "GCRA11"
            };*/

            string[] data_com = File.ReadAllLines(@"C:\\Users\\Carlos\\Documents\\Github\\SiteInvestidorDez\\DataBase\\Data-Com.txt");
            /*{
                "28/12/2023", //[1]
                "19/10/2023", //[1]
                "07/12/2023", //[1]
                "07/12/2023", //[1]
                "07/12/2023"  //[1]
            };*/

            string[] pagamento = File.ReadAllLines(@"C:\\Users\\Carlos\\Documents\\Github\\SiteInvestidorDez\\DataBase\\Pagamento.txt");
            /*{
                "15/01/2024", //[2]
                "26/10/2023", //[2]
                "14/12/2023", //[2]
                "14/12/2023", //[2]
                "14/12/2023"  //[2]
            };*/

            string[] valor = File.ReadAllLines(@"C:\\Users\\Carlos\\Documents\\Github\\SiteInvestidorDez\\DataBase\\Valor.txt");
            /*{
                "0,11000000", //[3]
                "6,90000000", //[3]
                "0,30000000", //[3]
                "1,20000000", //[3]
                "1,00000000"  //[3]
            };*/

            for (int i = 0; i < cotas.Length; i++)
            {
                EscreveTexto("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/span/input[2]", cotas[i]);
                ClicaElemento("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/button");
                ValidaClass("result-text", cotas[i]);
                ClickElementResult("//*[@id=\'results\']/div/div[2]/div[1]/div");
                ValidaDados("//*[@id='header_action']/div[1]/div[2]/h1", cotas[i]);
                ValidaDados("//td[@class='text-center']['07/12/2023'][2]", data_com[i]);
                ValidaDados("//td[@class='text-center']['07/12/2023'][3]", pagamento[i]);

                if (valor[i] == valor[i])
                {
                    ValidaDados("//td[@class='text-center']['07/12/2023'][4]", valor[i]);
                }
                    Console.WriteLine($"Será pago o mesmo valor do mês anterior: {pagamento[i]} {valor[i]}");
                
                
                ClicaElemento("//img[@alt='logo investidor10']"); //Volta para a busca

            }
            
        }
    }
}
