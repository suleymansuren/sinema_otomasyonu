using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu
{
    public class Movie
    {
        public int id;
        public IDictionary<string, Boolean[]> data;
        private Boolean[] chairs0 = new Boolean[64];
        private Boolean[] chairs1 = new Boolean[64];
        private Boolean[] chairs2 = new Boolean[64];
        private Boolean[] chairs3 = new Boolean[64];
        private Boolean[] chairs4 = new Boolean[64];
        private Boolean[] chairs5 = new Boolean[64];
        private Boolean[] chairs6 = new Boolean[64];

        public Movie(int _id)
        {
            data = new Dictionary<String, Boolean[]>();
            this.id = _id;

                for (int i = 0; i < 64; i++)
                {
                    chairs0[i] = true;
                    chairs1[i] = true;
                    chairs2[i] = true;
                    chairs3[i] = true;
                    chairs4[i] = true;
                    chairs5[i] = true;
                }


            data.Add("0", chairs0);
            data.Add("1", chairs1);
            data.Add("2", chairs2);
            data.Add("3", chairs3);
            data.Add("4", chairs4);
            data.Add("5", chairs5);
            data.Add("6", chairs5);
        }

        public void koltukKirala(String seans,int i)
        {
            data[seans][i] = false;
        }
    }
}
