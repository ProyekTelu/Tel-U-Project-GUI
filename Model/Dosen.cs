namespace Model
{
    public class Dosen
    {
        private String NIM { get; set; }
        private String email { get; set; }
        private String first_name { get; set; }
        private String last_name { get; set; }
        private String kode_dosen { get; set; }
        private bool gender { get; set; }
        private String prodi { get; set; }
        private String fakultas { get; set; }
        private int phone { get; set; }
        private List<Tim_Proyek> listTimProyek { get; set; }
        private List<Proyek> listProyek { get; set; }

        public Dosen(String email, String first_name, String last_name, bool gender)
        {
            this.email = email;
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
        }
    }
}
