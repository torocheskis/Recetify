namespace Recetify.Models;
public class Receta
{
    public string Nombre{get; set;}
    public DateTime FechaNacimiento{get; set;}
    public string TipoC{get; set;}
    public double Presupuesto{get; set;}
    public int Comensales{get; set;}


    public int CalcEdad()
    {
        int edad = DateTime.Today.Year - FechaNacimiento.Year;
        if(DateTime.Today.Month > FechaNacimiento.Month && DateTime.Today.Day > FechaNacimiento.Day)
        {
            edad -= 1;
        }

        return edad;
    }

    public string DeterminarComida()
    {
    string plato = "";
    if(TipoC == "Caliente" && Presupuesto <= 3000)
    {
        plato = "Fideos con manteca";
    }

    else if(TipoC == "Caliente" && Presupuesto <= 7000 && Presupuesto > 3000)
    {
        plato = "Arroz con verduras salteadas";
    }

    else if (TipoC == "Caliente" && Presupuesto > 7000)
    {
        plato = "Pollo al horno con guarnición";
    }

    else if (TipoC == "Fria" && Presupuesto <= 7000)
    {
        plato = "Ensalada simple";
    }

    else if (TipoC == "Fria" && Presupuesto <= 7000 && Presupuesto > 3000)
    {
        plato = "Ensalada completa con proteína";
    }

    else if (TipoC == "Fria" && Presupuesto > 7000)
    {
        plato = "Tabla de fiambres y quesos";
    }

    return plato;
    }

    public int CalcTiempo()
{
    int tiempo = 0;

    if(TipoC == "Caliente")
    {
        if (Comensales >= 1 && Comensales <= 3)
        {
            tiempo = 20;
        }

        else if (Comensales >= 4 && Comensales <= 7)
        {
            tiempo = 40;
        }

        else if (Comensales >= 8)
        {
            tiempo = 80;
        }
    }

    if(TipoC == "Fria")
    {
        if (Comensales >= 1 && Comensales <= 3)
        {
            tiempo = 10;
        }

        else if (Comensales >= 4 && Comensales <= 7)
        {
            tiempo = 20;
        }

        else if (Comensales >= 8)
        {
            tiempo = 40;
        }
    }

    return tiempo;
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
        else if (Comensales >= 1 && Comensales <= 7 && Presupuesto > 3000)
        {
            dif = "Intermedio";
        }
        else if (Comensales >= 8)
        {
            dif = "Avanzado";
        }

        return dif;
    }
}





