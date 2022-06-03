namespace LB210
{
    public class Jokes
    {
        public static int Count { get { return _jokes.Length; } }

        private static readonly string[] _jokes = {
            "Chuck Norris kann auch auf einem seriellen Kabel parallel senden.",
            "Auf dem Weg zur Arbeit springt einem Programmierer ein Frosch vor die Füße. 'Ich bin eine verzauberte Prinzessin, küss mich!' Der Programmierer steckt den Frosch in die Jackentasche. In der Mittagspause quakt es aus der Jacke. 'Bitte, bitte, küss mich, ich bin eine verzauberte Prinzessin.' Der Programmierer ignoriert den Frosch. Als er abends in der Kneipe das Tier aus der Jacke holt und vorführt, wird er gefragt, warum er den bettelnden Frosch nicht erhört? Darauf der Programmierer: 'Für eine Freundin habe ich keine Zeit, aber einen sprechenden Frosch finde ich cool ...'",
            "Der kürzeste Programmiererwitz: 'Gleich bin ich fertig!'",
            "Arbeiten am Computer ist wie U-Boot fahren: Wenn man ein Fenster aufmacht, fangen die Probleme an.",
            "„Mist! Facebook ist komplett down!“ – „Naja, die NSA braucht auch mal Urlaub…“",
            "Was ist Flach und Eckig? – Ein Minecraft Witz.",
            "Bist du mal wieder über mein WLAN-Kabel gestolpert?",
            "In einem Auto fahren ein Ingenieur, ein Physiker und ein Programmierer. Das Auto bleibt plötzlich mit einer Panne liegen. Da sagt der Ingenieur: “Mist, das liegt bestimmt an der Einspritzanlage, ich schau mir das mal an.” Sagt der Physiker: “Ach was, da ist nur ein Kabel lose.” Sagt der Programmierer: “Glaube ich nicht. Wir schliessen jetzt alle Fenster, steigen alle mal aus, dann wieder ein, und dann wird’s schon wieder gehen.”",
            "Anruf bei der Hotline…Kunde: “Ich benutze Windows…”Hotline: “Ja…?”Kunde: “…mein Computer funktioniert nicht richtig.”Hotline: “Das sagten Sie bereits …” ",
            "Zwei Mathematiker und zwei Physiker fahren zusammen mit der Bahn zu einem Kongress. Auf der Hinfahrt unterhalten sie sich über die Systematik des Fahrkartenverkaufs, wobei die Mathematiker erwähnen, dass sie nur eine Fahrkarte für zwei Personen brauchen. Als nach einiger Zeit der Schaffner kommt, gehen die beiden Mathematiker zusammen auf ein Klo. Kurz darauf klopft der Schaffner an die Tür und verlangt die Fahrkarte, die Mathematiker schieben ihre unter der Tür durch, und alles ist okay. Auf der Rückfahrt haben sie Physiker dazugelernt und auch nur eine Fahrkarte gekauft. Die Mathematiker haben dagegen gar keine! Wiederum nähert sich bald der Schaffner, und die Physiker begeben sich aufs Klo. Kurz darauf geht ihnen ein Mathematiker nach und klopft an die Tür: 'Die Fahrkarte, bitte!'",
            "Drei Männer fahren in einem Heißluftballon und verirrten sich in ein Tal. Einer von ihnen sagte: 'Ich hab’ eine Idee: Wir rufen um Hilfe, und das Echo hier verstärkt unsere Stimmen. Dann sind wir bestimmt auch über eine große Distanz zu hören.' Also lehnten sich alle drei über den Korbrand und brüllen: 'Hiiiiiiiiiiiiiiiiilfäääääääääää! Wo sind wir?' Rund 15 Minuten später hörten sie eine Stimme: - 'Haallooo! Ihr seid verloren!' Einer der Männer meint: 'Das war bestimmt ein Mathematiker.' Die anderen beiden sind etwas verwirrt: 'Wieso das?' 'Aus drei Gründen: Erstens brauchte er lange für die Antwort, zweitens hat er absolut recht und drittens war seine Antwort total überflüssig.'",
            "Ein Mathematiker, ein Physiker und ein Computer-Nutzer werden getrennt von einander eingeschlossen. Jeder erhält zwei Glaskugeln. Nach einer Stunde schaut man, was passiert ist. Der Mathematiker sitzt in seiner Zelle und berechnet das Volumen sowie die Oberfläche der Kugeln. Der Physiker hält die Kugeln gegen das Licht und berechnet Brechzahl und Absorptionskoeffizient. Als letztes schaut man beim Computer-Nutzer herein und stellt fest, dass eine Kugel fehlt und das Fenster zerbrochen ist. Auf die Frage, was denn passiert sei, zuckt der User nur mit den Schultern und sagt: 'Ich hab' nichts gemacht...!'"
        };
        public static string Get(int id)
        {
            if (id < 0 || id >= Count)
            {
                return "Was ist der Unterschied zwischen einem Informatiker und einem Physiker? Der Physiker glaubt, ein Kilobyte sind 1000 Byte. Der Informatiker glaubt, ein Kilometer sind 1024 Meter.";
            }
            return _jokes[id];
        }
    }
}
