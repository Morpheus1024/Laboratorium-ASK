import tkinter as tk
import threading
from tkinter import filedialog

# Inicjalizacja rejestrów
AL = ['0'] * 8
AH = ['0'] * 8
BL = ['0'] * 8
BH = ['0'] * 8
CL = ['0'] * 8
CH = ['0'] * 8
DL = ['0'] * 8
DH = ['0'] * 8

# Zdefiniowane zmienne
variables = {}

current_line = 0  # Zmienna przechowująca numer aktualnie wykonywanej linii

def zeruj_rejestry():
    global AL, AH, BL, BH, CL, CH, DL, DH
    AL = ['0'] * 8
    AH = ['0'] * 8
    BL = ['0'] * 8
    BH = ['0'] * 8
    CL = ['0'] * 8
    CH = ['0'] * 8
    DL = ['0'] * 8
    DH = ['0'] * 8

# Funkcje pomocnicze
def dec_to_bin(number):
    return bin(number)[2:].zfill(8)

def split_bits(binary_number):
    return [bit for bit in binary_number]

def update_line_numbers():
    lines = input_entry.get("1.0", tk.END).split("\n")
    line_numbers_text.delete(1.0, tk.END)
    for i in range(1, len(lines)):
        line_numbers_text.insert(tk.END, str(i) + "\n")

def on_enter_pressed(event):
    update_line_numbers()

def execute_assembly_code(is_step):
    global AL, AH, BL, BH, CL, CH, DL, DH, current_line, variables

    registers = {'AL': AL, 'AH': AH, 'BL': BL, 'BH': BH, 'CL': CL, 'CH': CH, 'DL': DL, 'DH': DH}
    command_lines = input_entry.get("1.0", tk.END).split("\n")

    if is_step:
        if current_line < len(command_lines):
            command = command_lines[current_line].strip()
            if command:
                cmd = command.split()
                if cmd:
                    if cmd[0] == "mov":
                        if len(cmd) == 3:
                            if cmd[2].startswith('[') and cmd[2].endswith(']'):
                                variable_name = cmd[2][1:-1]
                                if variable_name in variables:
                                    registers[cmd[1].replace(",", "")][:] = variables[variable_name][:]
                                else:
                                    print(f"Error: Variable {variable_name} not defined.")
                            else:
                                if cmd[2].isdigit():
                                    registers[cmd[1].replace(",", "")][:] = list(format(int(cmd[2]), '08b'))
                                else:
                                    if cmd[2] in registers:
                                        registers[cmd[1].replace(",", "")][:] = registers[cmd[2]][:]
                                    elif cmd[2] in variables:
                                        registers[cmd[1].replace(",", "")][:] = variables[cmd[2]][:]
                                    else:
                                        print(f"Error: Register or variable {cmd[2]} not found.")
                        else:
                            print("Error: Incorrect usage of MOV command.")
                    elif cmd[0] == "add":
                        if cmd[2].isdigit():
                            registers[cmd[1].replace(",", "")][:] = list(
                                bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) + int(cmd[2]))[2:])
                        else:
                            registers[cmd[1].replace(",", "")][:] = list(
                                bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) + int(
                                    ''.join(registers[cmd[2].replace(",", "")]), 2)))[2:]
                    elif cmd[0] == "sub":
                        if cmd[2].isdigit():
                            registers[cmd[1].replace(",", "")][:] = list(
                                bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) - int(cmd[2]))[2:])
                        else:
                            result = int(''.join(registers[cmd[1].replace(",", "")]), 2) - int(
                                ''.join(registers[cmd[2].replace(",", "")]), 2)
                            if result < 0:
                                result += 256  # Obsługa odejmowania modulo 256 dla wartości ujemnych
                            registers[cmd[1].replace(",", "")][:] = list(bin(result)[2:])
                    elif cmd[1] == "db":
                        if len(cmd) == 3 and cmd[2].isdigit():
                            variables[cmd[0]] = list(format(int(cmd[2]), '08b'))
                        else:
                            print("Error: Incorrect usage of DB command.")

            current_line += 1

            # Aktualizacja wartości rejestrów w interfejsie
            for reg_name, reg_value in registers.items():
                register_texts[reg_name].delete(1.0, tk.END)
                register_texts[reg_name].insert(tk.END, ''.join(reg_value).zfill(8))

    else:
        current_line = 0
        zeruj_rejestry()
        variables = {}
        for command in command_lines:
            cmd = command.strip().split()
            if cmd:
                if cmd[0] == "mov":
                    if len(cmd) == 3:
                        if cmd[2].startswith('[') and cmd[2].endswith(']'):
                            variable_name = cmd[2][1:-1]
                            if variable_name in variables:
                                registers[cmd[1].replace(",", "")][:] = variables[variable_name][:]
                            else:
                                print(f"Error: Variable {variable_name} not defined.")
                        else:
                            if cmd[2].isdigit():
                                registers[cmd[1].replace(",", "")][:] = list(format(int(cmd[2]), '08b'))
                            else:
                                if cmd[2] in registers:
                                    registers[cmd[1].replace(",", "")][:] = registers[cmd[2]][:]
                                elif cmd[2] in variables:
                                    registers[cmd[1].replace(",", "")][:] = variables[cmd[2]][:]
                                else:
                                    print(f"Error: Register or variable {cmd[2]} not found.")
                    else:
                        print("Error: Incorrect usage of MOV command.")
                elif cmd[0] == "add":
                    if cmd[2].isdigit():
                        registers[cmd[1].replace(",", "")][:] = list(
                            bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) + int(cmd[2]))[2:])
                    else:
                        registers[cmd[1].replace(",", "")][:] = list(
                            bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) + int(
                                ''.join(registers[cmd[2].replace(",", "")]), 2)))[2:]
                elif cmd[0] == "sub":
                    if cmd[2].isdigit():
                        registers[cmd[1].replace(",", "")][:] = list(
                            bin(int(''.join(registers[cmd[1].replace(",", "")]), 2) - int(cmd[2]))[2:])
                    else:
                        result = int(''.join(registers[cmd[1].replace(",", "")]), 2) - int(
                            ''.join(registers[cmd[2].replace(",", "")]), 2)
                        if result < 0:
                            result += 256  # Obsługa odejmowania modulo 256 dla wartości ujemnych
                        registers[cmd[1].replace(",", "")][:] = list(bin(result)[2:])
                elif cmd[1] == "db":
                    if len(cmd) == 3 and cmd[2].isdigit():
                        variables[cmd[0]] = list(format(int(cmd[2]), '08b'))
                    else:
                        print("Error: Incorrect usage of DB command.")

        # Aktualizacja wartości rejestrów w interfejsie
        for reg_name, reg_value in registers.items():
            register_texts[reg_name].delete(1.0, tk.END)
            register_texts[reg_name].insert(tk.END, ''.join(reg_value).zfill(8))


# Utworzenie okna głównego
root = tk.Tk()
root.title("Assembler Simulator")

# Utworzenie ramki dla pola tekstowego
code_frame = tk.Frame(root)
code_frame.pack(side=tk.TOP, padx=10, pady=10)

code_label = tk.Label(code_frame, text="Wpisz kod:")
code_label.pack()

line_numbers_frame = tk.Frame(code_frame)
line_numbers_frame.pack(side=tk.LEFT, fill=tk.Y)

line_numbers_text = tk.Text(line_numbers_frame, width=3, height=10, bg="#f0f0f0", bd=0)
line_numbers_text.pack(side=tk.LEFT, fill=tk.Y)

input_entry = tk.Text(code_frame, width=54, height=10)
input_entry.pack(side=tk.LEFT)
input_entry.bind("<Return>", on_enter_pressed)  # Dodanie zdarzenia dla klawisza Enter

# Ustawienie początkowej numeracji linii
update_line_numbers()

# Utworzenie ramki dla rejestrow
register_frame = tk.Frame(root)
register_frame.pack(side=tk.TOP, padx=10, pady=10)

register_label = tk.Label(register_frame, text="Rejestry:")
register_label.pack()

registers = {'AL': AL, 'AH': AH, 'BL': BL, 'BH': BH, 'CL': CL, 'CH': CH, 'DL': DL, 'DH': DH}
register_texts = {}

for reg_name, reg_value in registers.items():
    reg_frame = tk.Frame(register_frame)
    reg_frame.pack(fill=tk.X)

    reg_label = tk.Label(reg_frame, text=reg_name)
    reg_label.pack(side=tk.LEFT)

    reg_value_text = tk.Text(reg_frame, width=10, height=1, bg="#f0f0f0", bd=0)
    reg_value_text.insert(tk.END, ''.join(reg_value))
    reg_value_text.pack(side=tk.RIGHT)

    register_texts[reg_name] = reg_value_text


# Funkcja wykonująca kod
def execute_code():
    threading.Thread(target=lambda: execute_assembly_code(False)).start()
    update_line_numbers()

def step_code():
    threading.Thread(target=lambda: execute_assembly_code(True)).start()
    update_line_numbers()

def zapisz():
    threading.Thread(target=lambda: execute_assembly_code(False)).start()
    update_line_numbers()

    # Dodanie kodu do obsługi zapisu do pliku
    with open("output.txt", "w") as output_file:
        output_file.write(input_entry.get("1.0", tk.END))
        output_file.close()

def odczyt():
    try:
        file_path = filedialog.askopenfilename(initialdir="/", title="Wybierz plik",
                                               filetypes=(("Pliki tekstowe", "*.txt"), ("Wszystkie pliki", "*.*")))
        if file_path:
            with open(file_path, "r") as input_file:
                code = input_file.read()
                input_entry.delete("1.0", tk.END)
                input_entry.insert(tk.END, code)
                input_file.close()
                update_line_numbers()
    except FileNotFoundError:
        print("File not found.")



# Przyciski
execute_button = tk.Button(root, text="Wykonaj kod", command=execute_code)
execute_button.pack()

step_button = tk.Button(root, text="Praca krokowa", command=step_code)
step_button.pack()

zapisz = tk.Button(root, text="Zapisz do pliku tekstowego", command=zapisz)
zapisz.pack()

odczyt = tk.Button(root, text="Odczytaj z pliku tekstowego", command=odczyt)
odczyt.pack()

root.mainloop()