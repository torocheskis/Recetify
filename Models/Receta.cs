Public class Receta()
{
    public string Nombre{get; set;}
    public DateTime FechaNacimiento{get; set;}
    public string TipoC{get; set;}
    public double Presupuesto{get; set;}
    public int Comensales{get; set;}
}

public int CalcEdad()
{
    int edad = DateTime.today.year - FechaNacimiento.year;
    if(DateTime.today.month > FechaNacimiento.month && DateTime.today.day > FechaNacimiento.day)
    {
        edad += 1;
    }

    return edad
}

public string DeterminarComida()
{
    string plato = "";
    if(TipoC == "fria" && Presupuesto <= 3000)
    {
        plato = "Fideos con manteca";
    }

    else if(TipoC == "fria" && Presupuesto <= 7000 && Presupuesto > 3000)
    {
        plato = "Arroz con verduras salteadas";
    }

    else if (TipoC == "fria" && Presupuesto > 7000)
    {
        plato = "Pollo al horno con guarnición";
    }

    else if (TipoC == "caliente" && Presupuesto <= 7000)
    {
        plato = "Ensalada simple";
    }

    else if (TipoC == "caleinte" && Presupuesto <= 7000 && Presupuesto > 3000)
    {
        plato = "Ensalada completa con proteína";
    }

    else if (TipoC == "caliente" && Presupuesto > 7000)
    {
        plato = "Tabla de fiambres y quesos";
    }

    return plato;
}

public int CalcTimepo()
{
    int Timepo = 0;

    if(TipoC == "caliente")
    {
        if (Comensales >= 1 && Comensales <= 3)
        {
            Timepo = 20; 
        }
        else if (Comensales >= 4 && Comensales <= 7)
        {
            Tiempo = 40;
        }
        else if (Comensales >= 8)
        {
            Tiempo = 80
        }
    }

    if(TipoC == "fria")
    {
        if (Comensales >= 1 && Comensales <= 3)
        {
            Timepo = 10; 
        }
        else if (Comensales >= 4 && Comensales <= 7)
        {
            Tiempo = 20;
        }
        else if (Comensales >= 8)
        {
            Tiempo = 40
        }
    }
    return Tiempo;
}

public string DeterminarDificultad()
{
    string dif = "";
    if (Comensales >= 1 && Comensales <= 3 && Presupuesto <= 3000)
    {
        dif = "Principiante"; 
    }
    if (Comensales >= 4 && Comensales <= 7 && Presupuesto <= 3000)
    {
        dif = "Intermedio";
    }
    else if (Comensales >= 1 && Comensales = <= 7 && Presupuesto > 3000)
    {
        dif = "Intermedio";
    }
    else if (Comensales >= 8 &&)
    {
        dif = "Avanzado";
    }
}



