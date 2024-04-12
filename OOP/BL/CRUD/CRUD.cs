public interface CRUD<T>
{
    public T Create(T newTask);

    public T? Delete(object i);

    public T? Read(object i);

    public T? Update(T newTask);
}
