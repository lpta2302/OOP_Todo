public interface ICRUD<T>
{
    public T? Create(object[] args);
    public T Create(T newTask);

    public T? Delete(object i);

    public T? Read(object i);

    public T? Update(T newTask);
}
