using EjercicioInterfaces;

Carro carro1 = new()
{
  Modelo = "Sedán",
  Color = "Rojo"
};

Carro carro2 = new()
{
  Modelo = "Audi",
  Color = "Azul"
};

Moto moto1 = new()
{
  Marca = "Harley Davidson",
  Tipo = "Chopper"
};

Moto moto2 = new()
{
    Marca = "Indian",
    Tipo = "Deportiva"
};

// Usando los métod de la interfaz
carro1.Arrancar();
carro1.Conducir(50);
carro1.Detener();

carro2.Arrancar();
carro2.Conducir(20);
carro2.Detener();

moto1.Arrancar();
moto1.Conducir(30);
moto1.Detener();

moto2.Arrancar();
moto2.Conducir(50);
moto2.Detener();

Console.ReadLine();