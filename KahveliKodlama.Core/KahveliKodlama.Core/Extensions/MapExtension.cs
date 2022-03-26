using KahveliKodlama.Domain.Common;

namespace KahveliKodlama.Core.Extensions;

public static class MapExtension
{
    public static TEntity Merge<TEntity, TDto>(this TEntity entity, TDto dto) where TEntity : BaseEntity
    {
        foreach (var item in dto!.GetType().GetProperties())
        {

            var value = item.GetValue(dto);
            var typeOfRet = entity.GetType();

            if (value != null && typeOfRet.GetProperty(item.Name) is not null)
                typeOfRet.GetProperty(item.Name)!.SetValue(entity, value, null);

        
        }

        entity.LastModifyTime = DateTime.UtcNow;
        return entity;
    }
}
