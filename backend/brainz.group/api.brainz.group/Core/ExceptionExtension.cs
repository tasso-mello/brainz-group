namespace api.brainz.group.Core;

public static class ExceptionExtension
{
    public static IServiceCollection AddExceptionConfig(this IServiceCollection services)
    {
        services.AddMvc(options =>
        {
            options.EnableEndpointRouting = false;
            options.Filters.Add(typeof(CustomExceptions));
        });

        return services;
    }
}
