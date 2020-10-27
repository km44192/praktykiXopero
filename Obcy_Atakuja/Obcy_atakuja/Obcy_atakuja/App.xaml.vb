''' <summary>
''' Zapewnia zachowanie specyficzne dla aplikacji, aby uzupełnić domyślną klasę aplikacji.
''' </summary>
NotInheritable Class App
    Inherits Application

    ''' <summary>
    ''' Wywoływane, gdy aplikacja jest uruchamiana normalnie przez użytkownika końcowego. Inne punkty wejścia
    ''' będą używane, kiedy aplikacja zostanie uruchomiona, aby otworzyć określony plik, wyświetlić
    ''' wyniki wyszukiwania itd.
    ''' </summary>
    ''' <param name="e">Szczegóły dotyczące żądania uruchomienia i procesu.</param>
    Protected Overrides Sub OnLaunched(e As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

        ' Nie powtarzaj inicjowania aplikacji, gdy w oknie znajduje się już zawartość,
        ' upewnij się tylko, że okno jest aktywne

        If rootFrame Is Nothing Then
            ' Utwórz ramkę, która będzie pełnić funkcję kontekstu nawigacji, i przejdź do pierwszej strony
            rootFrame = New Frame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                ' TODO: Załaduj stan z wstrzymanej wcześniej aplikacji
            End If
            ' Umieść ramkę w bieżącym oknie
            Window.Current.Content = rootFrame
        End If

        If e.PrelaunchActivated = False Then
            If rootFrame.Content Is Nothing Then
                ' Kiedy stos nawigacji nie jest przywrócony, przejdź do pierwszej strony,
                ' konfigurując nową stronę przez przekazanie wymaganych informacji jako
                ' parametr
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If

            ' Upewnij się, ze bieżące okno jest aktywne
            Window.Current.Activate()
        End If
    End Sub

    ''' <summary>
    ''' Wywoływane, gdy nawigacja do konkretnej strony nie powiedzie się
    ''' </summary>
    ''' <param name="sender">Ramka, do której nawigacja nie powiodła się</param>
    ''' <param name="e">Szczegóły dotyczące niepowodzenia nawigacji</param>
    Private Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
    End Sub

    ''' <summary>
    ''' Wywoływane, gdy wykonanie aplikacji jest wstrzymywane. Stan aplikacji jest zapisywany
    ''' bez wiedzy o tym, czy aplikacja zostanie zakończona, czy wznowiona z niezmienioną zawartością
    ''' pamięci.
    ''' </summary>
    ''' <param name="sender">Źródło żądania wstrzymania.</param>
    ''' <param name="e">Szczegóły żądania wstrzymania.</param>
    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        ' TODO: Zapisz stan aplikacji i zatrzymaj wszelkie aktywności w tle
        deferral.Complete()
    End Sub

End Class
