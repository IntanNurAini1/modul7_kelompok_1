using modul7_kelompok_1;
using System;

class PProgram
{
    static void main(String[] args)
    {
        var Mahasiswa = new DataMahasiswa103022330075();
        Mahasiswa.ReadJSON();

        var Member = new teamMembers103022330075();
        Member.ReadJSON();
    }
}