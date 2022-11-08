//polimorfismo
            Veiculo[] listaveiculos = new Veiculo[5];
            listaveiculos[0] = new Mota();
            listaveiculos[1] = new Carro();
            listaveiculos[2] = new Carro();
            listaveiculos[3] = new Mota();
            listaveiculos[4] = new Mota();

            for(var i = 0; i < listaveiculos.Lenght; i++)
            {
                if (listaveiculos [i].GetType() == typeof(Mota))
                {
                    //mota faz x
                }

                if (listaveiculos[i].GetType() == typeof(Carro))
                {
                    //carro faz y
                }

            }