using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(12);
ItemNotaFiscal it2 = new ItemNotaFiscal(20);

NotaFiscal nf = new NotaFiscal(1,"22-09-2025");
nf.vetItens.Add(it1);
nf.vetItens.Add(it2);

Console.WriteLine("\nApresentação dos itens de nota fiscal");
foreach (var item in nf.vetItens)
{
    item.Mostrar();
}
//forçar a destruição do objeto chame o Coletor de Lixo
nf = null; //aqui a variável PERDE a referência de memória ficando disponível para o coletor de lixo, liberando a memória
GC.Collect();