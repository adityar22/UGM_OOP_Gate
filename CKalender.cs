using System;
namespace gate_prjct
{
    public class CKalender
    {
        public void menu(){
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("Kalender GATE");
                Console.WriteLine("Menu: (1)Cek Hari Bersejarah; (2)Baca Diary; (3)Tulis Diary; (-1)kembali");
                Console.WriteLine("Input pilihan: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        cek();
                        break;
                    case 2:
                        baca();
                        break;
                    case 3:
                        tulis();
                        break;
                    default:
                        break;
                } 
            }
        }
        private void cek(){
            CHBersejarah hari = new CHBersejarah();
        }
        private void baca(){
            CDiary diary = new CDiary();
            diary.baca();
        }
        private void tulis(){
            CDiary diary = new CDiary();
            diary.tulis();
        }

    }
}