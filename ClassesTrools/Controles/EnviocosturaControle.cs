using Modelos;

namespace Controles;

public class EnviocosturaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnviocosturaControle() : base()
  {
    NomeDaTabela = "Enviocostura";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Enviocostura>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Enviocostura>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Enviocostura>(NomeDaTabela);
    return new List<Enviocostura>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Enviocostura>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Enviocostura enviocostura)
  {
    var collection = liteDB.GetCollection<Enviocostura>(NomeDaTabela);
    collection.Upsert(enviocostura);
  }

  //----------------------------------------------------------------------------
}