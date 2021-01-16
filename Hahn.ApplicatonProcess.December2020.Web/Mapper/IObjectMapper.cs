using System.Linq;

namespace ApplicatonProcess.December2020.Web.Mapper
{
    public interface IObjectMapper
    {
        TDestination Map<TDestination>(object source);
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
        IQueryable<TDestination> ProjectTo<TDestination>(IQueryable source);
    }
}