using Modelos;

namespace Controles;

public class VendasControle : BaseControle
{
  //----------------------------------------------------------------------------

  public VendasControle () : base()
  {
    NomeDaTabela = "Vendas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Vendas>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Vendas>(NomeDaTabela);
    return new List<Vendas>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Vendas vendas)
  {
    var collection = liteDB.GetCollection<Vendas>(NomeDaTabela);
    collection.Upsert(vendas);
  }

  //----------------------------------------------------------------------------
}