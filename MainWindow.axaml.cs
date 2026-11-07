using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    private bool _saludoAlternativo;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnPresentarmeClick(object? sender, RoutedEventArgs e)
    {
        var nombre = NombreTextBox.Text?.Trim() ?? string.Empty;
        var apellido = ApellidoTextBox.Text?.Trim() ?? string.Empty;
        var edadTexto = EdadTextBox.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(nombre))
        {
            MostrarError("Por favor, escribe tu nombre.");
            NombreTextBox.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            MostrarError("Por favor, escribe tu apellido.");
            ApellidoTextBox.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(edadTexto))
        {
            MostrarError("Por favor, escribe tu edad.");
            EdadTextBox.Focus();
            return;
        }

        if (!int.TryParse(edadTexto, out var edad) || edad <= 0)
        {
            MostrarError("La edad debe ser un número entero positivo.");
            EdadTextBox.Focus();
            return;
        }

        var saludo = _saludoAlternativo ? "¡Qué gusto conocerte" : "¡Hola";
        ResultadoTextBlock.Text = $"{saludo}, {nombre} {apellido}! Tienes {edad} años.";
    }

    private void OnLimpiarClick(object? sender, RoutedEventArgs e)
    {
        NombreTextBox.Clear();
        ApellidoTextBox.Clear();
        EdadTextBox.Clear();
        ResultadoTextBlock.Text = "Tu presentación aparecerá aquí.";
        NombreTextBox.Focus();
    }

    private void OnCambiarSaludoClick(object? sender, RoutedEventArgs e)
    {
        _saludoAlternativo = !_saludoAlternativo;
        ResultadoTextBlock.Text = _saludoAlternativo
            ? "Saludo cambiado. Al presentarte, usaré «¡Qué gusto conocerte»."
            : "Saludo cambiado. Al presentarte, usaré «¡Hola».";
    }

    private void MostrarError(string mensaje)
    {
        ResultadoTextBlock.Text = mensaje;
    }
}
