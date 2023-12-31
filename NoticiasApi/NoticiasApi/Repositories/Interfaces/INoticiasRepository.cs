﻿using NoticiasApi.Models;

namespace NoticiasApi.Repositories.Interfaces;

public interface INoticiasRepository {
    IEnumerable <Noticia> BuscarTodas();
    //pode retornar uma noticia ou pode retornar nulo
    Noticia? BuscarPorId(int id);

    int Adicionar(Noticia noticia);
    int Alterar(Noticia noticia);
    int Excluir(int id);
}
