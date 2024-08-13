using Modelos;

namespace Controles;

public class CostureirosControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CostureirosControle() : base()
  {
    NomeDaTabela = "Costureiros";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Costureiros>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costureiros? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costureiros>(NomeDaTabela);
    return new List<Costureiros>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Costureiros>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costureiros costureiros)
  {
    var collection = liteDB.GetCollection<Costureiros>(NomeDaTabela);
    collection.Upsert(costureiros);
  }

  //----------------------------------------------------------------------------
}