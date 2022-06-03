namespace Atacado.DAL.Ancestral
{
    public interface IAncestralDAO<T> :
        IActionCreateDAO<T>,
        IActionDeleteDAO<T>,
        IActionReadDAO<T>,
        IActionUpdateDAO<T>
    {
    }
}
