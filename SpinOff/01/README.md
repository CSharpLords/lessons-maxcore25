1. В чем проблемы данного кода и как от них избавиться?

   1. ```csharp
      double temp = 2 * (height + width);
      Console.WriteLine(temp);
      temp = height * width;
      Console.WriteLine(temp);
      ```

   2. ```csharp
      static int CreateUniqueCasenumber(DateTime date, int departmentId) {
      	int temp = 0;
      
      	temp = date.Day;
      	temp = temp * 100;
      
      	temp = temp + date.Month;
      	temp = temp * 100;
      
      	temp = temp + date.Year;
      	temp = temp * 100;
      
      	temp = temp + (date.Hour * departmentId);
      
      	return temp;
      }
      ```

      