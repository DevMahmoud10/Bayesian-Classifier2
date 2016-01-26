using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Task3
{
    class Recognetion
    {
        public int width;
        public int height;
        Random r = new Random();
        public List<Section> classes= new List<Section>();
        public List<Action> actions = new List<Action>();
        public List<List<double>> lossMatrix = new List<List<double>>();

        public Recognetion() { }


        public Recognetion(string w, string h,List<Section>sec,List<Action>act,List<List<double>>LM)
        {
            this.classes.AddRange(sec);
            this.actions.AddRange(act);
            this.lossMatrix.AddRange(LM);
            this.width = int.Parse(w);
            this.height = int.Parse(h);

        }
    }
}
