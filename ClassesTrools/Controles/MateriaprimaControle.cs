using Modelos;

namespace Controles;

public class MateriaprimaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MateriaprimaControle () : base()
  {
    NomeDaTabela = "Materiaprima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Materiaprima? LerTodos()
  {
    var tabela = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return new List<Materiaprima>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Materiaprima materiaprimas)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    collection.Upsert(materiaprimas);
  }

  //----------------------------------------------------------------------------
}