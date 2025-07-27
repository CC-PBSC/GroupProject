# dictionary_app.py

def display_menu():
    print("\nChoose an option:")
    print("1. Populate the Dictionary")
    print("2. Display Dictionary Contents")
    print("3. Remove a Key")
    print("4. Add a New Key and Value")
    print("5. Add a Value to an Existing Key")
    print("6. Sort the Keys")
    print("7. Exit")

# Dictionary to store data
data_dict = {}

# 1a. Populate the Dictionary
def populate_dictionary():
    n = int(input("How many key-value pairs do you want to add? "))
    for _ in range(n):
        key = input("Enter key: ")
        value = input("Enter value: ")
        data_dict[key] = value
    print("Dictionary populated.")

# 1b. Display Dictionary Contents
def display_contents():
    print("\nChoose method to display dictionary:")
    print("a. Using items()")
    print("b. Using keys() and values()")
    print("c. Using a for loop with key access")
    option = input("Option: ").lower()

    print("\nDictionary Contents:")
    if option == 'a':
        for key, value in data_dict.items():
            print(f"{key}: {value}")
    elif option == 'b':
        keys = data_dict.keys()
        values = data_dict.values()
        for k, v in zip(keys, values):
            print(f"{k}: {v}")
    elif option == 'c':
        for key in data_dict:
            print(f"{key}: {data_dict[key]}")
    else:
        print("Invalid option.")

# 1c. Remove a Key
def remove_key():
    key = input("Enter the key to remove: ")
    if key in data_dict:
        del data_dict[key]
        print(f"{key} removed.")
    else:
        print("Key not found.")

# 1d. Add a New Key and Value
def add_new_pair():
    key = input("Enter new key: ")
    if key in data_dict:
        print("Key already exists.")
    else:
        value = input("Enter value: ")
        data_dict[key] = value
        print(f"{key}: {value} added.")

# 1e. Add a Value to an Existing Key
def append_to_existing_key():
    key = input("Enter existing key: ")
    if key in data_dict:
        new_value = input("Enter value to append: ")
        data_dict[key] += f", {new_value}"
        print(f"Updated {key}: {data_dict[key]}")
    else:
        print("Key not found.")

# 1f. Sort the Keys
def sort_keys():
    print("Sorted dictionary by keys:")
    for key in sorted(data_dict.keys()):
        print(f"{key}: {data_dict[key]}")

# Main loop with switch-like behavior
def main():
    while True:
        display_menu()
        choice = input("Enter your choice (1-7): ")
        if choice == '1':
            populate_dictionary()
        elif choice == '2':
            display_contents()
        elif choice == '3':
            remove_key()
        elif choice == '4':
            add_new_pair()
        elif choice == '5':
            append_to_existing_key()
        elif choice == '6':
            sort_keys()
        elif choice == '7':
            print("Exiting program.")
            break
        else:
            print("Invalid input. Please choose a number between 1 and 7.")

if __name__ == "__main__":
    main()
