import tkinter as tk
import socket
import threading

def start_server_window():
    def accept_client():
        global server_socket, client_socket
        server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server_socket.bind(('127.0.0.1', 5555))
        server_socket.listen(1)
        client_socket, client_address = server_socket.accept()

    accept_client()

    server_window = tk.Toplevel(root)
    server_window.title("Okno serwera")

    # Funkcja do wysyłania wiadomości z serwera
    def send_message():
        try:
            message = message_entry.get()
            formatted_message = format_message(message)
            send_data(formatted_message.encode())
            message_entry.delete(0, tk.END)
            # Dodaj wysłaną wiadomość do pola tekstowego
            sent_text.insert(tk.END, formatted_message + '\n')
        except Exception as e:
            print("Wystąpił błąd podczas wysyłania wiadomości:", e)

    # Funkcja do odbierania wiadomości na serwerze
    def receive_messages(client_socket):
        message_buffer = ""  # Bufor dla otrzymanych danych
        decoded_message_list = []
        while True:
            try:
                data = client_socket.recv(1024)
                receive_text.insert(tk.END, "\n")
                message_buffer += data.decode()  # Dodaj otrzymane dane do bufora
                lenght = len(message_buffer) / 8
                vulgar_word = False
                while len(message_buffer) >= 8:  # Sprawdź, czy wystarczająco danych do dekodowania
                    message_chunk = message_buffer[:8]  # Pobierz pierwsze 11 bitów
                    message_buffer = message_buffer[8:]  # Usuń pierwsze 11 bitów z bufora
                    decoded_message = decode_message(message_chunk)  # Dekoduj fragment
                    # Dodaj liste o nazawie decoded_message_list do ktorych wpisywane beda odkodowane wiadomosci
                    decoded_message_list.append(decoded_message)
                    # złącz liste w jedna wiadomosc
                    decoded_message = ''.join(decoded_message_list)
                    # sprawdzanie czy wiadomosc zawiera wulgaryzmy
                    with open('grubianstwa.txt', 'r') as file:
                        for line in file:
                            if line.strip() == decoded_message:
                                decoded_message = '*' * int(lenght)
                                receive_text.insert(tk.END, decoded_message)
                                vulgar_word = True
                            elif vulgar_word == False:
                                if len(decoded_message) == lenght:
                                    receive_text.insert(tk.END, decoded_message)

                decoded_message_list.clear()
            except ConnectionResetError:
                break

    # Funkcja do wysyłania danych na serwer
    def send_data(data):
        client_socket.send(data)

    # Formatowanie wiadomości do formatu bitów startu, danych i bitów stopu
    def format_message(message):
        formatted_message = ""
        for char in message:
            data_bits = bin(ord(char))[2:].zfill(8)  # Bity danych (ASCII)
            formatted_message += data_bits
        return formatted_message

    # Dekodowanie wiadomości z formatu bitów startu, danych i bitów stopu do ASCII
    def decode_message(encoded_message):
        decoded_message = ""
        i = 0
        while i + 7 <= len(encoded_message):  # Sprawdź, czy istnieje wystarczająco dużo danych do zdekodowania
            char_bits = encoded_message[i:i + 8]  # Pobierz 8 bitów danych
            decoded_char = chr(int(char_bits, 2))
            decoded_message += decoded_char
            i += 7  # Przesuń wskaźnik o 10 bitów (8 danych + 2 bity stopu)
        return decoded_message

    # Interfejs do wysyłania wiadomości z serwera
    send_frame = tk.Frame(server_window)
    send_frame.pack(pady=10)

    message_entry = tk.Entry(send_frame, width=50)
    message_entry.pack(side=tk.LEFT, padx=5)
    send_button = tk.Button(send_frame, text="Wyślij", command=send_message)
    send_button.pack(side=tk.LEFT, padx=5)

    # Pole do odbierania wiadomości
    receive_frame = tk.Frame(server_window)
    receive_frame.pack(pady=10)

    receive_label = tk.Label(receive_frame, text="Odbieranie wiadomości:")
    receive_label.pack()

    receive_text = tk.Text(receive_frame, width=50, height=10)
    receive_text.pack()

    # Pole do wysyłanych wiadomości
    sent_frame = tk.Frame(server_window)
    sent_frame.pack(pady=10)

    sent_label = tk.Label(sent_frame, text="Wysłane wiadomości:")
    sent_label.pack()

    sent_text = tk.Text(sent_frame, width=50, height=5)
    sent_text.pack()

    # Uruchomienie wątku do odbierania wiadomości na serwerze
    receive_thread = threading.Thread(target=receive_messages, args=(client_socket,))
    receive_thread.start()

def connect_device_window():
    device_window = tk.Toplevel(root)
    device_window.title("Okno urządzenia")

    # Funkcja do wysyłania wiadomości z klienta
    def send_message():
        try:
            message = message_entry.get()
            formatted_message = format_message(message)
            send_data(formatted_message.encode())
            message_entry.delete(0, tk.END)
            # Dodaj wysłaną wiadomość do pola tekstowego
            sent_text.insert(tk.END, formatted_message + '\n')
        except Exception as e:
            print("Wystąpił błąd podczas wysyłania wiadomości:", e)

    # Funkcja do odbierania wiadomości na kliencie
    def receive_messages(client_socket):
        message_buffer = ""  # Bufor dla otrzymanych danych
        decoded_message_list = []
        while True:
            try:
                data = client_socket.recv(1024)
                receive_text.insert(tk.END, "\n")
                message_buffer += data.decode()  # Dodaj otrzymane dane do bufora
                lenght = len(message_buffer)/8
                vulgar_word = False
                while len(message_buffer) >= 8:  # Sprawdź, czy wystarczająco danych do dekodowania
                    message_chunk = message_buffer[:8]  # Pobierz pierwsze 11 bitów
                    message_buffer = message_buffer[8:]  # Usuń pierwsze 11 bitów z bufora
                    decoded_message = decode_message(message_chunk)  # Dekoduj fragment
                    #Dodaj liste o nazawie decoded_message_list do ktorych wpisywane beda odkodowane wiadomosci
                    decoded_message_list.append(decoded_message)
                    #złącz liste w jedna wiadomosc
                    decoded_message = ''.join(decoded_message_list)
                    #sprawdzanie czy wiadomosc zawiera wulgaryzmy
                    with open('grubianstwa.txt', 'r') as file:
                        for line in file:
                            if line.strip() == decoded_message:
                                decoded_message = '*' * int(lenght)
                                receive_text.insert(tk.END, decoded_message)
                                vulgar_word = True
                            elif vulgar_word == False:
                                if len(decoded_message) == lenght:
                                    receive_text.insert(tk.END, decoded_message)

                decoded_message_list.clear()
            except ConnectionResetError:
                break

    # Funkcja do wysyłania danych na klienta
    def send_data(data):
        client_socket.send(data)

    # Formatowanie wiadomości do formatu bitów startu, danych i bitów stopu
    def format_message(message):
        formatted_message = ""
        for char in message:
            data_bits = bin(ord(char))[2:].zfill(8)  # Bity danych (ASCII)
            formatted_message += data_bits
        return formatted_message

    # Dekodowanie wiadomości z formatu bitów startu, danych i bitów stopu do ASCII
    def decode_message(encoded_message):
        decoded_message = ""
        i = 0
        while i + 7 <= len(encoded_message):  # Sprawdź, czy istnieje wystarczająco dużo danych do zdekodowania
            char_bits = encoded_message[i:i + 8]  # Pobierz 8 bitów danych
            decoded_char = chr(int(char_bits, 2))
            decoded_message += decoded_char
            i += 7  # Przesuń wskaźnik o 10 bitów (8 danych + 2 bity stopu)
        return decoded_message

    # Tworzenie gniazda klienta
    client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    client_socket.connect(('127.0.0.1', 5555))

    # Interfejs do wysyłania wiadomości z klienta
    send_frame = tk.Frame(device_window)
    send_frame.pack(pady=10)

    message_entry = tk.Entry(send_frame, width=50)
    message_entry.pack(side=tk.LEFT, padx=5)
    send_button = tk.Button(send_frame, text="Wyślij", command=send_message)
    send_button.pack(side=tk.LEFT, padx=5)

    # Pole do odbierania wiadomości
    receive_frame = tk.Frame(device_window)
    receive_frame.pack(pady=10)

    receive_label = tk.Label(receive_frame, text="Odbieranie wiadomości:")
    receive_label.pack()

    receive_text = tk.Text(receive_frame, width=50, height=10)
    receive_text.pack()

    # Pole do wysyłanych wiadomości
    sent_frame = tk.Frame(device_window)
    sent_frame.pack(pady=10)

    sent_label = tk.Label(sent_frame, text="Wysłane wiadomości:")
    sent_label.pack()

    sent_text = tk.Text(sent_frame, width=50, height=5)
    sent_text.pack()

    # Uruchomienie wątku do odbierania wiadomości na kliencie
    receive_thread = threading.Thread(target=receive_messages, args=(client_socket,))
    receive_thread.start()

# Tworzenie głównego okna
root = tk.Tk()
root.title("Aplikacja")

# Tworzenie przycisków
server_button = tk.Button(root, text="Serwer", command=start_server_window)
server_button.pack(pady=10)

device_button = tk.Button(root, text="Urządzenie", command=connect_device_window)
device_button.pack(pady=10)

# Uruchomienie pętli głównej
root.mainloop()
