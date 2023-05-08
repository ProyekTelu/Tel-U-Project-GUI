namespace Model
{
    public class Mahasiswa
    {
        private String NIM {get; set;}
        private String email {get; set;}
        private String first_name {get; set;}
        private String last_name {get; set;}
        private String nickname {get; set;}
        private bool gender {get; set;}
        private String prodi { get; set;}
        private String Fakultas {get; set;}
        private int phone {get; set;}
        private List<Tim_Proyek> listProyek { get; set;}

        public Mahasiswa(String email, String first_name, String last_name, bool gender)
        {
            this.email = email;
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
        }
    }
}