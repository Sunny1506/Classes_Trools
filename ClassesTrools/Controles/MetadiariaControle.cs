using Modelos;

namespace Controles;

public class MetaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MetaControle  () : base()
  {
    NomeDaTabela = "Meta";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Meta>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Meta? LerTodos()
  {
    var tabela = liteDB.GetCollection<Meta>(NomeDaTabela);
    return new List<Meta>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Meta>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Meta meta)
  {
    var collection = liteDB.GetCollection<Meta>(NomeDaTabela);
    collection.Upsert(meta);
  }

  //----------------------------------------------------------------------------
}