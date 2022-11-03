using System.Linq.Expressions;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        #region Métodos genéricos para consultar data
        // IReadOnlyList : se usa para retornar una lista de elementos de una colección y <T> es el tipo de elemento de la colección.
        Task<IReadOnlyList<T>> GetAllAsync();

        //cuando se llame a GetAsync() se le pasa un objeto de tipo expresión que se va a evaluar para determinar si el elemento de la colección cumple con la condición o no. esta expresión a futuro se va a transformar en una expresión de tipo SQL, donde va a ejecutar el query en la BBDD.
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        //Método para incluir el ordenamiento de los elementos de la colección.
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true
            );

        // Método para obtener un elemento de la colección. 
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true
            );

        Task<T> GetByIdAsync(int id);
        #endregion
    }
    
}
