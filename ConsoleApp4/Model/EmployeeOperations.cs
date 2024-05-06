namespace ConsoleApp4.Model
{
    /// <summary>
    /// <para>enum добавил чтобы не было магических чисел по типу if c==1 if c==2 </para> 
    /// <para>также добавил Extension метод (метод расширения)  EmployeeOperationsExtention для удобной  разделения логики</para> 
    /// </summary>
    public enum EmployeeOperations
    {
        Add=1,
        Write,
        Find,
        Delete,
        Edit,
    }

}
