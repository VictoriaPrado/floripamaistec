FileInfo arquivo = null;

try // zona segura
{
    Console.WriteLine("Digite o nome do arquivo que você vai criar: ");
    string nomeArquivo = Console.ReadLine();

    arquivo = new FileInfo(nomeArquivo);

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo");
    }
}
catch(ArgumentException ex)
{ 
    Console.WriteLine($"Tratando o erro expecificamente: {ex}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");

}
finally
{
    Console.WriteLine($"Encerrando programa...\n");
    //arquivo = null;
    //Console.Clear();
}
