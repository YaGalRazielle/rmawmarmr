﻿using MeowColonThree.Data;
using MeowColonThree.Models;

//EU ESTOU UTILIZANDO COPY PASTE BABYYYYYYYYYYYYY
// public bool TrustServerCertificate { get; set; } 
//o problema que aparentemenete o negocio esta sendo mandado por algo que n é de confianca
//yippie :autismcreature:

//27/05/2025
//i'm gonna be fr i'm fuckin losing it :3
// solucao 3 no site https://learn.microsoft.com/pt-br/troubleshoot/sql/database-engine/connect/certificate-chain-not-trusted?tabs=ole-db-driver-19
//é pra colocar ;TrustServerCertificate=true na cadeia de conexao
// entao o plano é lembrar o que isto é
// jogar o codigo la
// e rezar que funciona

namespace MeowColonThree.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
            //OKAY THIS IS BIZZARE.
            // a brand new error. took a screen shot and it's sticky notes.
            // but if someone ignored the sign that i put there,
            // (maybe i need to slap a giant red circle, just in case.)
            // SqlException: Não é possível abrir o banco de dados "DB_SistemaContatos" solicitado pelo logon. Falha de logon.
            // Falha de logon do usuário 'UWU\Aluno 01'.
            // InvalidOperationException: An exception has been raised that is likely due to a transient failure. Consider enabling transient error resiliency by adding 'EnableRetryOnFailure' to the 'UseSqlServer' call.
            // idk if i need to delete the thing i added in appsettings.json
            // but i feel like we did genuine progress here!
            // despite you know
            // you being in another room and teaching english
            // did also find something else out.
            // also put it in the sticky note but
            // i don't have the time to delve too deep into it.
        }
    }
}
