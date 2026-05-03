using System.Diagnostics;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public void IniciarJogo()
    {
        GameManager.Instance.IniciarJogo();
    }

    public void SairJogo()
    {
        GameManager.Instance.MudarEstado(GameManager.EstadoJogo.Iniciando);
    }
}