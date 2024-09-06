namespace BankOfCodeland;

public interface IValidator<T>
{
    bool IsValid(T t);
}