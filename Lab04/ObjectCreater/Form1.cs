using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Collection collection;

        private void CreateCollection_Click(object sender, EventArgs e)
        {
            try
            {
                if (collection == null)
                {
                    int count = int.Parse(this.CountBox.Text);
                    collection = new Collection(count);
                    foreach (var item in collection.list)
                    {
                        this.entireCollection.Items.Add(item.ToString());
                    }
                }
                else
                {
                    int count = int.Parse(this.CountBox.Text);

                    collection.AddElement(count);

                    for (int i = 0; i < count; i++)
                    {
                        this.entireCollection.Items.Add(collection.list.ElementAt(collection.count).ToString());
                        collection.count++;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void findMinValue_Click(object sender, EventArgs e)
        {
            if (collection == null)
                return;
            Circle buffCircle = collection.list.Min();
            this.showResult.Items.Add(buffCircle.ToString());
        }

        private void findMaxValue_Click(object sender, EventArgs e)
        {
            if (collection == null)
                return;
            Circle buffCircle = collection.list.Max();
            this.showResult.Items.Add(buffCircle.ToString());
        }

        private void counterButton_Click(object sender, EventArgs e)
        {
            if (collection == null)
                return;
            int count = collection.list.Count;
            this.showResult.Items.Add($"В коллекции {count} объектов");
        }

        private void descendingSort_Click(object sender, EventArgs e)
        {
            if (collection == null)
                return;
            collection.descendingSort();
            this.showResult.Items.Add("");
            foreach (var item in collection.list)
            {
                this.showResult.Items.Add(item.ToString());
            }
            
        }

        private void ascendingSort_Click(object sender, EventArgs e)
        {
            if (collection == null)
                return;
            collection.ascendingSort();
            this.showResult.Items.Add("");
            foreach (var item in collection.list)
            {
                this.showResult.Items.Add(item.ToString());
            }
        }
    }
}
