namespace exa
{
    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Autor> autors = new List<Autor>();
        List<Revista> revistas = new List<Revista>();
        Autor a;

        int i = 0;
        int lib = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_autor.Enabled = false;
           cmb_periodo.Enabled = false;
            dateTime_publicacion.Enabled = false;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
           
            ListViewItem item = new ListViewItem(cmb_tipo.Text);
            if (cmb_tipo.Text == "Libro")
            {
                item.SubItems.Add(txt_autor.Text);
                item.SubItems.Add(dateTime_publicacion.Text);
                item.SubItems.Add("---");

                Libro li = new Libro(txt_titulo.Text, double.Parse(txt_costo.Text), dateTime_publicacion.Text, txt_autor.Text, (i+=1));
                libros.Add(li);
                a = new Autor((i += 1), txt_autor.Text, "------", (lib += 1));
                autors.Add(a);
            }
            else
            {
                item.SubItems.Add("---");
                item.SubItems.Add("---");
                item.SubItems.Add(cmb_periodo.Text);
                Revista nu = new Revista(txt_titulo.Text, double.Parse(txt_costo.Text),cmb_periodo.Text);
                revistas.Add(nu);


            }
            item.SubItems.Add(txt_costo.Text);
            lst_ta.Items.Add(item);


            
           
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 0)
            {
                txt_autor.Enabled = true;
                cmb_periodo.Enabled = false;
                dateTime_publicacion.Enabled = true;
            }
            else
            {
                txt_autor.Enabled = false;
                cmb_periodo.Enabled = true;
                dateTime_publicacion.Enabled = false;
            }
        }

        int mas;
        string nombre;
        private void button1_Click(object sender, EventArgs e)
        {
            a = autors.FirstOrDefault();
            
            mas = a.libro_publicados;

            var mas_libros = (from au in autors
                              where au.libro_publicados > mas
                              select au).ToList();
            if (mas_libros.Count != 0)
            {

                foreach (Autor aux in mas_libros)
                {
                    if (aux.libro_publicados == mas)
                    {
                        nombre = aux.Name;
                    }
                }

            }

            MessageBox.Show($"autor {nombre} libros {mas}");



        }
    }
}