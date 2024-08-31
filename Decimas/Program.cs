public interface IMotor
{
    void CrearMotor(); // Método para crear el motor
}

public interface IRuedas
{
    void CrearRuedas(); // Método para crear las ruedas
}

public interface ICarroceria
{
    void CrearCarroceria(); // Método para crear la carrocería
}

// Interfaz para la fábrica abstracta
public interface IFabricaVehiculo
{
    IMotor CrearMotor(); // Método para obtener una instancia de motor
    IRuedas CrearRuedas(); // Método para obtener una instancia de ruedas
    ICarroceria CrearCarroceria(); // Método para obtener una instancia de carrocería
}

// Implementaciones de componentes de autos
public class MotorAuto : IMotor
{
    public void CrearMotor()
    {
        Console.WriteLine("-.Creando motor de auto");
    }
}

public class RuedasAuto : IRuedas
{
    public void CrearRuedas()
    {
        Console.WriteLine("-.Creando ruedas de auto");
    }
}

public class CarroceriaAuto : ICarroceria
{
    public void CrearCarroceria()
    {
        Console.WriteLine("-.Creando carrocería de auto");
    }
}

// Fábrica concreta de autos
public class FabricaAuto : IFabricaVehiculo
{
    public IMotor CrearMotor()
    {
        return new MotorAuto(); // Devuelve una instancia de MotorAuto
    }

    public IRuedas CrearRuedas()
    {
        return new RuedasAuto(); // Devuelve una instancia de RuedasAuto
    }

    public ICarroceria CrearCarroceria()
    {
        return new CarroceriaAuto(); // Devuelve una instancia de CarroceriaAuto
    }
}

// Implementaciones de partes de motos
public class MotorMoto : IMotor
{
    public void CrearMotor()
    {
        Console.WriteLine("-.Creando motor de moto");
    }
}

public class RuedasMoto : IRuedas
{
    public void CrearRuedas()
    {
        Console.WriteLine("-.Creando ruedas de moto");
    }
}

public class CarroceriaMoto : ICarroceria
{
    public void CrearCarroceria()
    {
        Console.WriteLine("-.Creando carrocería de moto");
    }
}

// Fábrica concreta de motocicletas
public class FabricaMoto : IFabricaVehiculo
{
    public IMotor CrearMotor()
    {
        return new MotorMoto(); // Devuelve una instancia de MotorMoto
    }

    public IRuedas CrearRuedas()
    {
        return new RuedasMoto(); // Devuelve una instancia de RuedasMoto
    }

    public ICarroceria CrearCarroceria()
    {
        return new CarroceriaMoto(); // Devuelve una instancia de CarroceriaMoto
    }
}

// Implementaciones de partes de camiones
public class MotorCamion : IMotor
{
    public void CrearMotor()
    {
        Console.WriteLine("-.Creando motor de camión");
    }
}

public class RuedasCamion : IRuedas
{
    public void CrearRuedas()
    {
        Console.WriteLine("-.Creando ruedas de camión");
    }
}

public class CarroceriaCamion : ICarroceria
{
    public void CrearCarroceria()
    {
        Console.WriteLine("-.Creando carrocería de camión");
    }
}

// Fábrica concreta de camiones
public class FabricaCamion : IFabricaVehiculo
{
    public IMotor CrearMotor()
    {
        return new MotorCamion(); // Devuelve una instancia de MotorCamion
    }

    public IRuedas CrearRuedas()
    {
        return new RuedasCamion(); // Devuelve una instancia de RuedasCamion
    }

    public ICarroceria CrearCarroceria()
    {
        return new CarroceriaCamion(); // Devuelve una instancia de CarroceriaCamion
    }
}
// Cliente que utiliza las fábricas
public class Cliente
{
    private readonly IMotor _motor;
    private readonly IRuedas _ruedas;
    private readonly ICarroceria _carroceria;

    // Constructor que recibe una fábrica concreta
    public Cliente(IFabricaVehiculo fabrica)
    {
        _motor = fabrica.CrearMotor(); // Instancia el motor usando la fábrica
        _ruedas = fabrica.CrearRuedas(); // Instancia las ruedas usando la fábrica
        _carroceria = fabrica.CrearCarroceria(); // Instancia la carrocería usando la fábrica
    }

    // Método para crear el vehículo
    public void CrearVehiculo()
    {
        _motor.CrearMotor(); // Crea el motor
        _ruedas.CrearRuedas(); // Crea las ruedas
        _carroceria.CrearCarroceria(); // Crea la carrocería
    }
}

public class Program
{
    public static void Main()
    {
        // Crear un auto usando la fábrica de autos
        IFabricaVehiculo fabricaAuto = new FabricaAuto();
        Cliente clienteAuto = new Cliente(fabricaAuto);
        Console.WriteLine("1.Creando auto:");
        clienteAuto.CrearVehiculo();

        // Crear una moto usando la fábrica de motos
        IFabricaVehiculo fabricaMoto = new FabricaMoto();
        Cliente clienteMoto = new Cliente(fabricaMoto);
        Console.WriteLine("\n2.Creando moto:");
        clienteMoto.CrearVehiculo();

        // Crear un camión usando la fábrica de camiones
        IFabricaVehiculo fabricaCamion = new FabricaCamion();
        Cliente clienteCamion = new Cliente(fabricaCamion);
        Console.WriteLine("\n3.Creando camión:");
        clienteCamion.CrearVehiculo();
    }
}