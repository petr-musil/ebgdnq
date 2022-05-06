import random
import sqlite3
import sys

DATABASE_FILENAME = "judo.db"


def generate_contestant():
    name = random.choice(
        ["Jiří", "Jan", "Petr", "Josef", "Pavel", "Martin", "Tomáš", "Jaroslav", "Miroslav", "Zdeněk", "Václav",
         "Michal", "Jakub", "Milan", "Karel", "Lukáš", "David", "Vladimír", "Ondřej"])
    surname = random.choice(
        ["Svoboda", "Novotný", "Dvořák", "Černý", "Procházka", "Kučera", "Veselý", "Krejčí", "Horák", "Němec", "Marek"])
    age = random.randint(5, 70)
    level = random.randint(0, 10)
    email = random.choice(["seznam.cz", "centrum.cz", "atlas.cz"])
    email = name.lower() + "." + surname.lower() + "@" + email
    email = email.replace("ě", "e").replace("é", "e")
    email = email.replace("á", "a").replace("š", "s")
    email = email.replace("č", "c").replace("ř", "r")
    email = email.replace("ý", "y").replace("í", "i")
    return (name, surname, email, age, level)


def generate_contestants(number_of_contestants):
    return [generate_contestant() for x in range(number_of_contestants)]


def insert_contestants_to_db(contestants):
    db_connection = sqlite3.connect(DATABASE_FILENAME)
    db_cursor = db_connection.cursor()
    db_cursor.executemany('INSERT INTO contestants VALUES (?,?,?,?,?)', contestants)
    db_connection.commit()
    db_connection.close()


def create_database():
    db_connection = sqlite3.connect(DATABASE_FILENAME)
    db_cursor = db_connection.cursor()

    # Create table
    db_cursor.execute("CREATE TABLE contestants (name text NOT NULL, surname text NOT NULL, email text UNIQUE NOT NULL, age integer, level integer)")
    # Just be sure any changes have been committed, or they will be lost when the connection is closed

    db_connection.commit()
    db_connection.close()


def show_db_data():
    db_connection = sqlite3.connect(DATABASE_FILENAME)
    db_cursor = db_connection.cursor()
    for row in db_cursor.execute("SELECT rowid, * FROM contestants"):
        print(row)


if __name__ == '__main__':
    if len(sys.argv) < 2:
        print("Chybí parametr! (create_db, generate_contestants, show_data)")
        exit()
    if sys.argv[1] == "create_db":
        create_database()
    if sys.argv[1] == "generate_contestants":
        if len(sys.argv) < 3:
            print("Chybí počet účastníků!")
            exit()
        contestants = generate_contestants(int(sys.argv[2]))
        insert_contestants_to_db(contestants)
    if sys.argv[1] == "show_data":
        show_db_data()

