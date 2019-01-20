using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemoApp.Model;

namespace WpfDemoApp.DataBase
{
    public class BookDatabase
    {
        public static ObservableCollection<Model.Book> GetBooks( ) {
           
            ObservableCollection<Book> returnValue = new ObservableCollection<Book>();

            returnValue.Add(new Book("978-3-8362-1956-3", "Galileo Computing", "WPF - Das umfassende Handbuch", "Thomas Claudius Huber", "Geballtes Wissen zum Grafik-Framework von .NET! Ob Grundlagen, XAML, GUI-Entwicklung, Datenbindung, Animationen, Multimedia oder Migration - hier finden Sie auf jede Frage eine Antwort! Grundkenntnisse in C# vorausgesetzt, ist dieses Buch sowohl zum Einstieg als auch als Nachschlagewerk optimal geeignet."));
            returnValue.Add(new Book("978-3-8273-7019-8", "Pearson Studium - IT", "Moderne Betriebssysteme", "Andrew S. Tannenbaum", "Andrew Tanenbaum zählt zu den bekanntesten und erfolgreichsten Lehrbuchautoren. Im Unterschied zur Erstauflage von 1992 legt Tanenbaum nun einen Schwerpunkt auf die traditionellen Single Processor-Systeme. Enthalten ist jedoch auch umfassender Lehrstoff zu Verteilten Systemen, der in einem zweiten Kursabschnitt gelehrt werden kann. Zum Üben des Stoffes gibt es 450 zum Teil neue oder aktualisierte Übungsaufgaben. Über den Autor: ANDREW S.TANENBAUM ist Professor für Informatik und gilt mit sechs internationalen Bestsellern zu Themen der Informatik als einer der erfolgreichsten Autoren seines Fachs.Zurzeit lehrt und forscht er an der Vrije Universiteit in Amsterdam."));
            returnValue.Add(new Book("978-3-446-41445-7", "Hanser", "Theoretische Grundlagen der Informatik", "Rolf Socher", "Das Buch bietet einen Einstieg in die theoretischen Grundlagen der Informatik. Es beschränkt sich auf die klassischen Themen: formale Sprachen, endliche Automaten und Grammatiken, Turing-Maschinen, Berechenbarkeit und Entscheidbarkeit, Komplexität. Das Konzept der Transformation zwischen den verschiedenen Formalismen zieht sich wie ein roter Faden durch das gesamte Buch."));
            returnValue.Add(new Book("978-3-446-42756-3", "Hanser", "Angewandte Kryptographie", "Wolfgang Ertel", "Die angewandte Kryptographie spielt im Zeitalter der Vernetzung und des E-Commerce eine zentrale Rolle beim Schutz von vertraulichen Daten und persönlicher Identität. Sie umfasst die Themen Verschlüsselung, Public Key Kryptographie, Authentifikation, digitale Signatur, elektronisches Bargeld und sichere Netze. Ziel des Buches ist es, Grundwissen über Algorithmen und Protokolle zu vermitteln und kryptographische Anwendungen aufzuzeigen. Als Beispiele dienen Entwicklungen wie der Advanced Encryption Standard (AES) oder Angriffe gegen das Public Key System PGP bzw. gegen Krypto-Chipkarten."));

            return returnValue;
        }

        public static ObservableCollection<Examples.Book> GetExampleBooks()
        {

            ObservableCollection<Examples.Book> returnValue = new ObservableCollection<Examples.Book>();

            returnValue.Add(new Examples.Book("978-3-8362-1956-3", "Galileo Computing", "WPF - Das umfassende Handbuch", "Thomas Claudius Huber"));
            returnValue.Add(new Examples.Book("978-3-8273-7019-8", "Pearson Studium - IT"
                , "Moderne Betriebssysteme", "Andrew S. Tannenbaum"));
            returnValue.Add(new Examples.Book("978-3-446-41445-7", "Hanser", "Theoretische Grundlagen der Informatik", "Rolf Socher"));
            returnValue.Add(new Examples.Book("978-3-446-42756-3", "Hanser", "Angewandte Kryptographie", "Wolfgang Ertel"));

            return returnValue;
        }
    }
}
