namespace Wiso_Learning_App
{
    public class Questions
    {
        public List<Wiso_Q> LoadQuestions()
        {
            var WisoList = new List<Wiso_Q>();

            //WisoList.Add(new Wiso_Q()
            //{
            //    Id = WisoList.Count + 1,
            //    Choices = 1,
            //    IsMultipleChoice = false,
            //    QuestionHeader = "",
            //    Question = "",
            //    AnswerHeader = "",
            //    Answers = new[] {
            //         "",
            //         ""
            //         }
            //});

            // SO-13

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Pflichten von Auszubildenden sind im Berufsbildungsgesetz (BBIG) und in der Verordnung über die Berufsausbildung geregelt.",
                Question = "Welche der folgenden Aufgaben sind Pflichten des Auszubildenden Varsten Vogt?",
                AnswerHeader = "",
                Answers = new[] {"Erledigung von betrieblichen Aufgaben, die nicht dem Ausbildungszweck dienen",
                     "Teilname an Schulungen der Gewerkschaft",
                     "Teilname an Ausbildungsmaßnahmen, die außerhalb der Ausbildungsstätte stattfinden.",
                     "Erstellen eines Ausbildungsplans, mit dem die geforderten Kenntnisse und Fertigkeiten erlangt werden können",
                     "Zahlung von Schadensersatz an den Ausbildenden (WÄRMGUT GmbH) nach Auflösung des Ausbildungsvertrags in der Probezeit, wenn der Ausbildungsplatz in Folge unbesetzt bleibt",
                     "Teilnahme an der Zwischenprüfung"}
            });


            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Herr Vogt nennt Ansprüche, die ihm die WÄRMGUT GmbH erfüllen soll",
                Question = "Welche der folgenden Ansprüche muss die WÄRMGUT GmbH aufgrund der rechtlichen Bestimmungen nicht erfüllen",
                AnswerHeader = "",
                Answers = new[] {"Verkürzung der Probezeit auf zwei Wochen",
                     "Erstattung der Fahrkosten zur Berufsschulung",
                     "Anmeldung zur Zwischen- und Abschlussprüfung",
                     "Kostenlose Überlassung von Ausbildungsmitteln",
                     "Ausbildung durch fachlich und persönlich geeignete Ausbilder",
                     "Freistellung zum Besuch der Berufsschule",
                     "Charakterliche Förderung"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Auszubildende Hanna Schmidt bittet Sie kurz vor erfolgreicher Beendigung ihrer Ausbildung um eim qualifiziertes Zeugnis.",
                Question = "Welche der folgenden Aussagen müssen Sie nach den gesetzlichen Vorschriften berücksichtigen?",
                AnswerHeader = "Das qualifizierte Zeugnis ...",
                Answers = new[] {"bedarf der Zustimmung des Betriebsrats.",
                     "bedarf der Zustimmung der Jugend- und Ausbildendenvertretung.",
                     "darf keine Angaben über das verhalten der Auszubildenden enthalten.",
                     "muss der Auszubildenden auf Anforderung ausgestellt werden.",
                     "kann von der Auszubildenden nicht eingefordert werden."}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die WÄRMGUT GmbH hat im Rahmen der Berufsausbildung gegenüber der Industrie- und Handelskammer (IHK) Rechte und Pflichten.",
                Question = "Welche der folgenden Aussagen ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {"Recht, Auszubildende ohne Zustimmung der IHK auszubilden",
                     "Pflicht, den betrieblichen Ausbildungsplan von der IHK genehmigen zu lassen",
                     "Pflicht, jede Fehlzeit der Auszubildenden sofort der IHK zu melden",
                     "Pflicht, dem Schlichtungsausschuss der IHK jede Unstimmigkeit mit Auszubildenden mitzuteilen",
                     "Recht, von der IHK eine Verschiebung des Prüfungstermins zu verlangen, wenn die Auftragslage es erfordert"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Europäische Arbeitnehmer haben ein Recht auf Freizügigkeit, d.h. dass sie sich in Ländern wie Spanien, Italien oder Großbritannien einen Arbeitsplatz suchen können.",
                Question = "Welche der folgenden Einrichtungen bietet Arbeitnehmern einen Service, ihre Qualifikation und Fähigkeiten in vorbereiteten Formularen so darzustellen, dass sie europaweit verständlich sind?",
                AnswerHeader = "",
                Answers = new[] {"UNESCO",
                     "Nationales Europass-Center (NEC)",
                     "Bundesagentur für Arbeit",
                     "Bundesinstitut für Berufsbildung",
                     "Gewerkschaften"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Ausbildungsleiterin der WÄRMGUT GmbH, Frau Bruckmann, schlägt vor, dass Sie mittelfristig auch als Ausbilder arbeiten sollen.",
                Question = "Welche der folgenden Vorraussetzungen müssen Sie nach den gesetzlichen Regelungen u. a. erfüllen, um als verantwoorlicher Ausbilder von der zuständigen IHK anerkannt zu werden?",
                AnswerHeader = "Sie müssen ...",
                Answers = new[] {"Mitglied im zuständigen Prüfungsausschuss sein.",
                     "über eine entsprechende persönliche Eignung verfügen.",
                     "jährlich ein Weiterbildungsseminar der IHK besuchen",
                     "Mitglied der Geschäftsleitung sein",
                     "Mitglied einer Gewerkschaft sein"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der WÄRMGUT GmbH soll die Stelle des Programmiers Ralf Schmidt, der in den Ruhestand geht, neu besetzt werden. Herr Schmidt hatte einen unbefristeten Arbeitsvertrag",
                Question = "Welche der folgenden Aussagen zur Neubesetzung der Stelle ist zutreffend?",
                AnswerHeader = "Die WÄRMGUT GmbH ...",
                Answers = new[] {"muss die freie Stelle der Bundesagentur für Arbeit melden.",
                     "darf die Stelle nur für männliche bewerber ausschreiben.",
                     "darf mit dem neuen Stelleninhaber keinen befristeten Arbeitsvertrag abschließen.",
                     "muss die Angaben in den Lebensläufen der Bewerber anhand von Originalunterlagen (z.B. Originalzeugnis) überprüfen.",
                     "muss als Mitglied des Arbeitgeberverbands beim Abschluss des Arbeitsvertrags den aktuellen Tarifvertrag einhalten."}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Sie sollen neue Mitarbeiter und Auszubildende der WÄRMGUT GmbH über Regelungen nach dem Entgeldfortzahlungsgesetz im Falle einer Arbeitsunfähigkeit informieren.",
                Question = "Welche der folgenden Fragen im Zusammenhang mit einer ärztlich festgestellten Arbeitsunfähigkeit von Mitarbeitern müssen Sie mit 'Ja' beantworten?",
                AnswerHeader = "",
                Answers = new[] {"Muss ich mehr als ein Jahr in der WÄRMGUT GmbH gearbeitet haben, um bei Krankheit einen Anspruche auf Fortzahlung meines Arbeitsentgelts zu haben?",
                     "Kann ich mir zur Vorlage einer ärztlichen Bescheinigung zur Arbeitsunfähigkeit sieben Werktage Zeit lassen?",
                     "Muss ich eine ärztliche Arbeitsunfähigkeitsbescheinigung vorlegen, wenn die Krankheit länger als drei Kalendertage dauert?",
                     "Verliere ich meinen Ansprich auf Entgeltfortzahlung im Krankheitsfall, wenn ich meine Arbeitsunfähigkeit fahrlässig verursacht habe?",
                     "Stimmt es, dass Auszubildenden bei Krankheit keine Ausbildungsvergütung gezahlt wird?"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "In der WÄRMGUT GmbH soll eine neue Betriebsvereinbarung getroffen werden, an deren Ausarbeitung Sie beteiligt sind.",
                Question = "Welche der folgenden Aussagen zu einer Betriebsvereinbarung sind zutreffend?",
                AnswerHeader = "Eine Betriebsvereinbarung ...",
                Answers = new[] {"muss zwischen der Geschäftsleitung und der entsprechenden Gewerkschaft abgeschlossen werden.",
                     "bedarf der notariellen Beurkundung.",
                     "kann über den Tarifvertrag positiv hinausgehende Vereinbarungen enthalten.",
                     "gilt nicht für Auszubildende der WÄRMGUT GmbH.",
                     "gilt nur für die gewerkschaftlich organisierten Arbeitnehmer der WÄRMGUT GmbH.",
                     "gilt für alle Mitarbeiter der WÄRMGUT GmbH."}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 4,
                IsMultipleChoice = true,
                QuestionHeader = "Die WÄRMGUT GmbH muss in Zuge einer Umstrukturierung eine Abteilung auflösen und Mitarbeiter entlassen.",
                Question = "Sie sollen prüfen, für welche der folgenden Mitarbeitgruppen eine besonderer Kündigungsschutz besteht.",
                AnswerHeader = "",
                Answers = new[] {"Handlungsbevollmächtigte",
                     "Auszubildende",
                     "Ungelernte Kräfte",
                     "Mitarbeiter unter 25 Jahre",
                     "Ausbilder",
                     "Schwangere",
                     "Schwerbehinderte Menschen",
                     "Betriebsratmitglieder",
                     "Sicherheitsbeauftragte",
                     "Gewerkschaftsmitglieder",
                     "Verheiratete"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die WÄRMGUT GmbH hat für die Sicherheit ihrer Mitarbeiter am Arbeitsplatz zu sorgen.",
                Question = "Welche der folgenden Stellen ist Ansprechpartner der WÄRMGUT GmbH bei Angelegenheiten der Arbeitssicherheit?",
                AnswerHeader = "",
                Answers = new[] {"Amt für Arbeitsschutz und Sicherheitstechnik (Gewerbeaufsicht)",
                     "Arbeitgeberverband",
                     "Industrie- und Handelskammer",
                     "Allgemeine Ortskrankenkasse",
                     "Technischer Überwachungsverein"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Sozialversicherungsbeiträge für Vollbeschäftigte müssen vom Arbeitgeber vollständig an eine der folgenden Institutionen überwiesen werden." +
                           "\nVon dort aus werden die einzelnen Beiträge an die entsprechenden Stellen weitergeleitet.",
                Question = "An welche der folgenden Institutionen muss die WÄRMGUT GmbH die Beiträge zur Sozialversicherung überweisen?",
                AnswerHeader = "",
                Answers = new[] {"Agentur für Arbeit",
                     "Deutsche Rentenkasse",
                     "Krankenkasse",
                     "Berufsgenossenschaft",
                     "Gesundheitsfonds"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Persoberatung KG führt in der WÄRMGUT GmbH eine Maßnahme zur Personalentwicklung durch, an der Sie teilnehmen sollen." +
                           "\nUnter  anderem werden für Mitarbeiter Potenzialanalysen erstellt.",
                Question = "Welche deer folgenden Aussagen bescheibt die Potenzialanalyse?",
                AnswerHeader = "",
                Answers = new[] {"Vorgesetzte sprechen mit Mitarbeitern über Aufstiegsmöglichkeiten.",
                     "Vorgesetzte versuchen zusammen mit einzelnen Mitarbeitern herauszufinden, welche besonderen Fähigkeiten entwickelt werden können.",
                     "Mitarbeitern werden Prämien in Aussicht gestellt.",
                     "das Unternehmen bietet Weiterbildungslehrgänge an.",
                     "Die Mitarbeiter arbeiten in Projektteams zusammen."}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In einem Arbeitstreffen analysieren Sie verschiedene Marktsituationen.",
                Question = "Welcher der folgenden Indikatoren weist auf einen Käufermarkt hin?",
                AnswerHeader = "",
                Answers = new[] {
                     "Verkäufer bieten kostenlose Zusatzleitungen an.",
                     "Lagerbestände werden in kurzer Zeit abgebaut.",
                     "Verkäufer gewähren keine Preisnachlässe.",
                     "Käufer akzeptieren lange Lieferzeiten.",
                     "Verkäuferinsolvenzen sind zurückgegangen."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Bei gleichbleibender Leistungserstellung will die WÄRMGUT GmbH die Arbeitsproduktivität je Mitarbeiter steigern.",
                Question = "Welche der folgenden Maßnahmen ist dazu geeignet?",
                AnswerHeader = "",
                Answers = new[] {
                     "Einstellung neuer Mitarbeiter",
                     "Zeitverträge werden nicht verlängert",
                     "Verlängerung der wöchentlichen Arbeitszeit",
                     "Erhöhung der Preise",
                     "Senkung der Preise"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Sie sollen für das abgelaufene Geschäftsjahr die Eigenkapitalrentabilität der WÄRMGUT GmbH ermitteln.",
                Question = "Mit welcher der folgenden Formeln wird die Eigenkapitalrentabilität in Prozent berechnet?",
                AnswerHeader = "",
                Answers = new[] {
                     "Eigenkapital * 100 / Anlagevermögen",
                     "Gewinn * 100 / Eigenkapital",
                     "Eigenkapital * 100 / Gesamtkapital",
                     "Gewinn * 100 / Umsatzerlöse",
                     "Umsatzerlöse / Eigenkapital"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die WÄRMGUT GmbH will ein Tochterunternehmen in der Rechtsform einer GmbH mit vorerst zehn Mitarbeitern gründen.",
                Question = "Welche der folgenden Vorschriften sind dabei zu beachten?",
                AnswerHeader = "",
                Answers = new[] {
                     "Als Firma muss eine Sachfirma gewählt werden.",
                     "Die Gründung kann alleine durch die WÄRMGUT GmbH erfolgen.",
                     "Das Stammkapital muss mindestens 25.000,00 EUR betragen.",
                     "Ein Aufsichtsrat muss bestellt werden.",
                     "Die WÄRMGUT GmbH haftet solidarisch für das Tochterunternehmen.",
                     "Die Gründung bedarf der Genehmigung des Kartellamtes."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die WÄRMGUT GmbH schließt mit der Weber AG einen Vertrag über die Aufrüstung von 500 Steueranlagen zu einem Festpreis.",
                Question = "Mit welcher der folgenden Maßnahmen handelt sie nach dem Minimalprinzip?",
                AnswerHeader = "Minimierung ...",
                Answers = new[] {
                     "des Risikos einer verspäteten Zahlung der Weber AG durch einen hohen Skonto.",
                     "des Riskos verspäteter Fertigstellung des Auftrages durch zusätzliche Zeitarbeitskräfte.",
                     "des finanziellen Risikos aus Gewährleistungsansprüchen durch eine Rückstellung.",
                     "der Kosten durch Optimierung des Geschäftsprozesses.",
                     "der Abhängigkeit von Lieferern durch Bestellungen bei mehreren Anbietern."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Subsidiarität ist ein gesellschaftspolitisches Prinzip, das in der Bundesrepublik Deutschland angewendet wird.",
                Question = "Welcher der folgenden Sachverhalte entspricht dem Prinzip Subsidiarität?",
                AnswerHeader = "",
                Answers = new[] {
                     "Die Versicherungspflichtgrenze für die gesetzliche Krankenversicherung wird erhöht.",
                     "Die Steuern auf privaten Renten werden erhöht.",
                     "Die Erbschaftssteuer wird erhöht.",
                     "Eltern mit den höchsten Einkommen zahlen die höchsten Kindergartenbeiträge, andere weniger.",
                     "Betroffene erhalten keine Sozialhilfe, solange sie verwertbares Privatvermögen besitzen."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die WÄRMGUT GmbH handelt mit Unternehmen in den Usa. In einem bestimmten Zeitraum ist der Kurs des EUR von 1,40 USD auf 1,20 USD gefallen.",
                Question = "Welche der folgenden Auswirkungen ist aufgrund dieser Entwicklung in der Regel zu erwarten?",
                AnswerHeader = "Die WÄRMGUT GmbH ...",
                Answers = new[] {
                     "kann nun in den USA günstiger einkaufen.",
                     "erhält mehr Aufträge aus den USA.",
                     "erhält weniger Aufträge aus den USA.",
                     "muss ein Produkt zu 1.000,00 EUR in den USA nun 200,00 USD teurer anbieten, um keinen Verlust zu erleiden.",
                     "kann den Verkaufspreis in EUR für ein US-Produkt, dessen Einkaufspreis auf dem Kurs 1,40 USD kalkuliert wurde, ohne Gewinnverlust um 14,3% senken."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Sie wollen sich mit einem Server-Ferndiagnosedienst selbstständig machen. Bei den Kreditgesprächen mit einer Bank wird die Vorlage eines Businessplanes verlangt.",
                Question = "An welcher der folgenden Stellen in Ihrem Businessplan erwartet die Bank Aussagen zu anderen Unternehmen, die ähnliche Dienstleistungen anbieten?",
                AnswerHeader = "",
                Answers = new[] {
                     "Unternehmensbeschreibung",
                     "Standortbeschreibung",
                     "Beschreibung der produkte und Leistungen",
                     "Markt- und Wettbewerbsanalyse",
                     "Finanzplanung"
                     }
            });

            // SO-15

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Zur Krypto-Control GmbH liegen folgende Daten vor." +
                                 "\nIT-Dienstleister" +
                                 "\n56% Marktanteil in der Region" +
                                 "\n58 Mitarbeiter" +
                                 "\n610.000 EUR Gewinn im Jahr 2014",
                Question = "Welche der folgenden Angaben trifft auf die Krypto-Control GmbH zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Großunternehmen",
                     "Marktführer",
                     "Monopolist",
                     "Unternehmen des primären Sektors",
                     "Versorgungsunternehmen"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der Krypto-Control GmbH muss das Allgemeine Gleichbehandlungsgesetz (AGG) beachtet werden.",
                Question = "In welchem der folgenden FFälle erfolgt eine Diskriminierung im Sinne des AGG?",
                AnswerHeader = "Die Krypto-Control GmbH ...",
                Answers = new[] {
                     "führt Englisch als Unternehmens sprache ein.",
                     "will den Anteil von Frauen in Führungspositionen erhöhen und ermutigt in Stellenanzeigen besonders Frauen, sich auf die ensprechenden Stellen zu bewerben.",
                     "richtet einen Aufzug in die erste Etage des Bürogebäudes ein, der nur von körperlich behinderten Menschen benutzt werden darf. Die übrigen Mitarbeiter müssen die treppen benutzen.",
                     "bietet älteren Mitarbeitern ab dem 55. Lebensjahr Altersteilzeitverträge an.",
                     "will einen guten Personalmix erreichen und fordert daher in Stellenausschreibungen von den Bewerbern bestimmmte Merkmale wie Geschlecht oder Alter ein."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der Krypto-Control GmbH muss die Arbeitssicherheit gewährleistet sein.",
                Question = "Welche der folgenden Aussagen trifft auf die Arbeitssicherheit in Unternehmen zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Betriebliche Arbeitsschutzbestimmmungen sind kein zwingendes Recht des Arbeitsverhältnisses und Verstöße durch Mitarbeiter führen somit nicht zu arbeitsrechtlichen Konsequenzen.",
                     "Eine Unternehmung mit mehr als 20 Beschäftigten muss einen Arbeitsschutzausschuss einrichten, in dem Themen des Arbeitsschutzes erörtert werden.",
                     "Die Ergonomie von Arbeitsplätzen ist keine Anforderung der Arbeitssicherheit, sondern ist eine freiwillige Leistung des Arbeitgebers zur Verbesserung der Leistungsfähigkeit von Mitarbeitern.",
                     "Die regelmäßige unterweisung der Arbeitnehmer zum betrieblichen Arbeitsschutz erfolgt durch extreme Berater der Gewerkschaft als die für den Arbeitsschutz zuständige Institution.",
                     "Eine Mitbestimmung von Arbeitnehmern beim Arbeitsschutz ist ausgeschlossen, da das Arbeitsschutzgesetz die Pflichten der Arbeitgeber im Einzelnen regelt."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Das Arbeitsverhältnis einer neuen Mitarbeitering mit der Krypto-Control GmbH ist in einem schriftlichen Arbeitsvertrag geregelt.",
                Question = "Bei welchem der folgenden Bestandteile des Arbeitsvertrags ist der Arbeitgeber an kollektives Arbeitsrecht gebunden?",
                AnswerHeader = "",
                Answers = new[] {
                     "Das monatliche Bruttogehalt beträgt 2.000,00 EUR",
                     "Die Angestelle arbeitet als Sachbearbeiterin im Kundenservice.",
                     "Das Arbeitsverhältnis beginnt am 1.April 2015",
                     "Die reguläre wöchentliche Arbeitszeit beträgt gemäß Betriebsvereinbarung 38,5 Stunden.",
                     "Die Krypto-Control GmbH gewährt einen monatlichen Fahrkostenzuschuss von 100,00 EUR."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Krypto-Control GmbH ist Mitglued eines Arbeitgeberverbandes.",
                Question = "Welche der folgenden Aussagen trifft auf Arbeitgeberverbände zu?",
                AnswerHeader = "Arbeitgeberverbände ...",
                Answers = new[] {
                     "können Gesetze im Wirtschaftsrecht erlassen.",
                     "setzen sich für ein stärker regulierendes Arbeitsrecht ein.",
                     "setzen die Einhaltung der Tarifverträge bei allen Unternehmen einer Branche durch.",
                     "vertreten ihre Mitglueder in sozial- und arbeitsrechtlichen Belangen.",
                     "nehmen nur Unternehmen mit Betriebsräten als Mitglieder auf."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Viele Mitarbeiter der Krypto-Control GmbH sind Mitglieder einer Gewerkschaft.",
                Question = "Welche der folgenden Aussagen trifft auf Gewerkschaft zu?",
                AnswerHeader = "Gewerkschaften ...",
                Answers = new[] {
                     "sind dem Bundesministerium für Arbeit und Soziales unterstellt.",
                     "stellen für die Betriebsräte in Mitgliederunternehmen eigenes Personal ab.",
                     "besitzen das Recht, Arbeitsbedingungen in einem Tarifvertrag zu regeln.",
                     "setzen sich für eine Liberalisierung des Arbeitsrechts ein.",
                     "dürfen nur dann Arbeitskampfmaßnahmen durchführen, wenn sie den zu erwartenden Lohnausfall und Gewinnverlust aus ihren Streikfonds(Streikkassen) ausgleichen können."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der Krypto-Control GmbH wurde ein Betriebsrat gewählt.",
                Question = "Welche der folgenden Aussagen über den Betriebsrat ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Ein Betriebsrat muss in jedem Betrieb gewählt werden",
                     "Ein Betriebsrat muss zur hälfte aus Arbeitnehmern und Arbeitnehmerinnen gebildet werden.",
                     "In einem Betriebsrat können nur Arbeitnehmer gewählt werden, die dem Betrieb mindestens ein Jahr angehören",
                     "Ein Betriebsrat kann von allen Arbeitnehmern eines Betriebs gewählt werden, die das 18. Lebensjahr vollendet haben.",
                     "Ein Betriebsrat muss alle zwei Jahre neu gewählt werden."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Geschäftsleitung der Krypto-Control GmbH arbeitet end mit dem Betriebsrat zusammen.",
                Question = "In welchen der folgenden Angelegenheiten hat der Betriebsrat laut Betriebsverfassungsgesetz ein Mitbestimmungsrecht?",
                AnswerHeader = "",
                Answers = new[] {
                     "Einführung eines Personalbeurteilungssystems",
                     "Planung des Personalbedarfs",
                     "Festlegung von Beginn und Ende der täglichen Arbeitszeit",
                     "Errichtung einer neuen Lagerhalle",
                     "Gründung einer Filiale",
                     "Umwandlung der Rechtsform"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Für Arbeitgeber und Arbeitnehmer ist die Tarifautonomie gesetzlich festgeschrieben.",
                Question = "Welche der folgenden Aussagen treffen auf die Tarifautonomie zu?",
                AnswerHeader = "Die Tarifautonomie ...",
                Answers = new[] {
                     "ist ein im Betriebsvcerfassungsgesetz (BetrVG) verankertes Recht.",
                     "gibt den Vertragsparteien das Recht, unabhängig von staatlicher Einflussnahme die Arbeits- und Wirtschaftsbedingungen zu regeln.",
                     "gibt den Vertragsparteien das Recht, unter staatlicher Beteiligung Vereinbarungen zu treffen.",
                     "ist individuelles Arbeitsrecht zur Regelung der Beziehungen zwischen einem Arbeitgeber und einem Arbeitnehmer.",
                     "gibt den Vertragsparteien das Recht zu Vereinbarungen, die von den Vertragspartnern nicht zu Ungunsten der Arbeitnehmer abgeändert werden dürfen.",
                     "gibt den Vertragsparteien das Recht zu Regelungen, die schlechter sind als die in Gesetzen genannten."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Arbeitnehmer der Krypto-Control GmbH wollen sich weiterbilden.",
                Question = "Welche der folgenden Aussagen zur Weiterbildung ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Sie wird nur bis zum 55. Lebensjahr staatlich gefördert, da bei älteren Arbeitnehmern eine Weiterbildung unrentabel ist.",
                     "Sie ist für Arbeitnehmer grundsätzlich kostenfrei, weil entweder das Unternehmen oder der Staat aus einem Bildungsfonds den Lohnausfall und die Weiterbildungskosten erstattet.",
                     "Sie kann nur außerbetrieblich in Einrichtungen zertifizierter Bildungsträger erfolgen.",
                     "Sie muss immer als Aufstiegsfortbildung mit einer Abschlussprüfung vor der Industie- und Handelskammer angelegt sein.",
                     "Sie erfolgt zur Vertiefung und Erweiterung von Kenntnissen und Fertigkeiten."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Eine Mitarbeiterin der Krypto-Control GmbH ist arbeitsunfähig, weil sie am Vortag auf dem direkten Weg zur Arbeit bei einem Verkehrsunfall schwer verletzt wurde.",
                Question = "Welche der folgenden Aussagen ist in diesem Zusammenhang zutreffend?",
                AnswerHeader = "Die Krypto-Control GmbH ...",
                Answers = new[] {
                     "muss den Unfall der Krankenversicherung der Mitarbeiterin melden.",
                     "darf die Gehaltszahlung ab dem ersten Krankheitstag einstellen.",
                     "darf den Urlaubsanspruch der Mitarbeitering kürzen.",
                     "muss den Unfall der Gewerbeaufsichtsbehörde melden.",
                     "muss den Unfall der Berufsgenossenschaft melden."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Nach der letzten Gehaltserhöhung übersteigt das Bruttogehalt von Dagmar Fuchs die Beitragsbemessungsgrenze für die gesetliche Rentenversicherung.",
                Question = "Welche der folgenden Konsequenzen ergibt sich aus der Gehaltserhöhung für Frau Fuchs?",
                AnswerHeader = "Frau Fuchs ...",
                Answers = new[] {
                     "ist nicht mehr versichungspflichtig.",
                     "muss sich nun privat versichern.",
                     "erhält für die Sozialversicherung keinen Arbeitgeberanteil mehr.",
                     "muss nun für einen Teil ihres Gehaltes keinen Rentenversicherungsbeitrag mehr leisten.",
                     "kann die Beiträge an die Rentenversicherung gegen Selbstbehalt reduzieren."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Solidarität ist ein gesellschaftspolitisches Prinzip, das in der Bundesrepublik Deutschland angewendet wird.",
                Question = "Welcher der folgenden Sachverhalte entspricht dem Prinzip der Solidarität?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Staat senkst die Beitragsermessungsgrenze für die gesetzliche Krankenkasse.",
                     "Der Staat fordert verstäkrt Selbstverantwortung bei der Altersvorsorge.",
                     "Der Staat erhöht die Erbschaftssteuer zur Umverteilung großer Vermögen.",
                     "Kindergartenbeiträge sind für alle Eltern, unabhängig vom Einkommen, gleich hoch.",
                     "Der Beitrag zur Krankenversicherung steigt mit individuellem Krankheitsrisiko des Versichterten."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Mitarbeiter der Krypto-Control GmbH diskutieren in der Mittagspause über die unterschiedlichen Möglichkeiten einer privaten Altersversorge.",
                Question = "Welche der folgenden wirtschaftlichen Entwicklungen gefährdet eine private Altersvorsorge?",
                AnswerHeader = "",
                Answers = new[] {
                     "Hohe Inflation",
                     "Konjukturaufschwung",
                     "Nachfrageüberhang",
                     "Moderate Lohnforderung",
                     "Senkung der Beiträge für die gesetzliche Arbeitslosenversicherung"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Krypto-Control GmbH ist ein erwerbswirtschaftliches Unternehmen.",
                Question = "Welche der folgenden Aussagen treffen auf ein erwerbswirtschaftliches Unternehmen zu",
                AnswerHeader = "",
                Answers = new[] {
                     "Arbeitet zur Deckung des Bedarfs an Gütern",
                     "Strebt einen Gewinn an",
                     "Arbeitet auf eigene Rechnung und Verantwortung",
                     "Betreibt öffentliche Daseinsvorsorge",
                     "Wirtschaftet nach einem öffentlichen Wirtschaftsplan mit dem Ziel der Kostendeckung",
                     "Muss jeden Kunden zu seinen allgemeinen Bedingungen und Preisen beliefern",
                     "Wird in seinen Entscheidungen nicht von Wettbewerbern eingeschränkt"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Sie erfahren von der Gründung der Volt GmbH, einem neuen Mitbewerber.",
                Question = "Mit welchem der folgenden Ereignisse wird eine GmbH rechtsfähig?",
                AnswerHeader = "Mit ...",
                Answers = new[] {
                     "Eintragung in das Handelsregister",
                     "Anmeldung beim Amtsgericht",
                     "Abschluss des ersten Rechtsgeschäfts",
                     "Einzahlung des Stammkapitals",
                     "Bestellung des Geschäftsführers"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Krypto-Control GmbH will ein IT-Servicecenter in der Rechtsform einer GmbH gründen.",
                Question = "Welche der folgenden Aussagen zur GmbH ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Das Stammkapital muss mindestens 50.000 EUR betragen.",
                     "Die Gesellschaft muss von mindestens zwei Personen gegründet werden.",
                     "Die Firma kann 'Gesellschaft für IT-Service mbH' lauten",
                     "Die Geschäftsführung der GmbH obliegt dem Vorstand.",
                     "Die neu gegründete GmbH ist eine natürliche Person des privaten Rechts."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Das Verhalten von Konsumenten hängt von verschiedenen Faktoren ab.",
                Question = "Welche der folgenden Aussagen ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Bedarf der Konsumenten ist gleich der Menge ihrer Bedürfnisse.",
                     "Der Bedarf der Konsumenten ist abhängig von deren Kaufkraft.",
                     "Die Nachfrage der Konsumenten ist abhängig vom Angebot",
                     "Die Bedürfnisse der Konsumenten entspricht dem Angebot.",
                     "Die bedürfnisse der Konsumenten entsprechen deren Nachfrage."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Der Verbraucherschutz ist ein zentrales Element der sozialen Marktwirtschaft.",
                Question = "Welche der folgenden Aussagen trifft auf den Verbraucherschutz zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Viele dem Verbraucherschutz dienenden Rechtsnormen sind im Bürgerlichen Gesetzbuch (BGB) verankert, z.B. die Vorschriften über Fernabsatzverträge.",
                     "Träger des Verbraucherschutzes sind die Unternehmen, welche die Verbraucher umfassend und objektiv über ihre Produkte und Dienstleistungen informieren müssen.",
                     "Der Verbraucherschutz schließt die Nachteile aus, welche aufgrund mangelnder Fachkenntnis, Informationen und/oder Erfahrung der Konsumenten entstehen.",
                     "Der Verbraucherschutz bezieht sich alleine auf Produkte, welche die Gesundheut der Verbraucher schädigen können, z.B. Lebensmittel, Medikamente, Trinkwasser.",
                     "Der Verbraucherschutz ist ein Zweig der Sozialversicherung zur Absicherung von Risiken aus privatrechtlichen Verträgen wie Kaufverträgen und Mietverträgen."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Arbeitnehmer treffen Maßnahmen zur persönlichen Existenzsicherung.",
                Question = "Welcher der folgenden Maßnahmen ist zur persönlichen Existenzsicherung geeignet?",
                AnswerHeader = "",
                Answers = new[] {
                     "Kauf eines Sportwagens auf Kredit zur eigenen Nutzung",
                     "Abschluss einer Versicherung für den Fall der Berufsunfähigkeit",
                     "Abschluss eines Ratenkaufvertrags aufgrund fehlender Liquidität",
                     "Abschluss einer Risikolebensversicherung zur Absicherung von Krediten",
                     "Abschluss einer privaten Zusatzkrankenversicherung"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Herr Scholz, ein 21-jähriger Mitarbeiter der Krypto-Control GmbH, will kündigen und ein eigenes Unternehmen gründen, um als Vollkaufmann einen Onlineshop für IT-Zubehör zu betreiben.",
                Question = "Welche der folgenden Aussagen zur Unternehmensgründung ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Zur Absicherung von Krediten muss die Unternehmensform Gesellschaft mit beschränkter Haftung (GmbH) gewählt werden.",
                     "Die Industrie- und Handelskammer verlangt von Herrn Scholz den Nachweis seiner fachlichen Qualifikation zum Betrieb eines kaufmännisch zu führenden Unternehmens.",
                     "Herr Scholz muss sein vollkaufmännisch geführtes Unternehmen im Handelsregister eintragen lassen.",
                     "Als selbstständig Erwerbstätiger ist Herr Scholz von der Einkommenssteuerpflicht befreit, wenn er Gewerbesteuer zahlt.",
                     "Als selbstständig Erwerbstätiger ist Herr Scholz von der Krankenversicherungspflicht befreit."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Arbeitsleistung der Krypto-Control GmbH wird von verschiedenen Wirtschaftseinheiten erbracht.",
                Question = "In welchem der folgenden Fälle handelt es sich um einer betriebliche Arbeitsteilung (Arbeitszerlegung)?",
                AnswerHeader = "Die Krypto-Control GmbH ...",
                Answers = new[] {
                     "gliedert einen Schritt eines Leistungsprozess an die OS GmbH aus.",
                     "lässt von einem Mitarbeiter ein Produkt aus Komponenten zusammenbauen, die von verschiedenen externen Unternehmen hergestellt wurden.",
                     "organisiert mehrere Prozesse als Supply Chain, in denen Lieferanten, Abteilungen der Krypto-Control GmbH und Kunden miteinander vernetzt sind.",
                     "eröffnet eine Filiale in einem anderen Bundesland, die in allen Geschäftsfeldern selbstständig operieren soll.",
                     "produziert ein Produkt in mehrere Arbeitsschritte, die von verschiedenen Arbeitskräften ausgeführt werden."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Krypto-Control GmbH hat sich mit den Auswirkungen der Globalisierung auseinanderzusetzen.",
                Question = "Welche der folgenden Auswirkungen trifft auf die Krypto-Control GmbH zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Durch den Zugang zu internationalen Märkten kann die Krypto-Control GmbH neue Märkte erschließen.",
                     "Da Deutschland ein Niedriglohnland ist, stehen der Krypto-Control GmbH ausreicht Fachkräfte zur Verfügung.",
                     "Alle Aufträge der Krypto-Control GmbH werden weltweit in EUR abgewickelt.",
                     "Ausländische Fachkräfte haben jederzeit Zugang zum deutschen Arbeitsmarkt und können von der Krypto-Control GmbH sofort eingestellt werden.",
                     "Durch einen Rückgang der Transporte der Krypto-Control GmbH sinkt der Preis für Kraftstoffe."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Wirtschaftsordnung Deutschlands wird als soziale Marktwirtschaft bezeichnet.",
                Question = "Welche der folgenden Aussagen trifft auf die soziale Marktwirtschaft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Staat greift aktiv in das Wirtschaftsgeschehen ein, um unsoziale Auswirkungen von Marktprozessen zu vermeiden.",
                     "Die Produktionsmittel dürfen kein privates Eigentum sein.",
                     "Die Gewinne dürfen von den Anbietern bis zur Gewinnschwelle frei kalkuliert werden.",
                     "Es dürfen nur die Berufe ausgebildet werden, die auf dem Arbeitsmarkt nachgefragt werden.",
                     "Die staatliche Wettbewerbspolitik soll den Wettbewerb einschränken und Monopole sowie Kartelle zur Stabilisierung der Märkte fördern."
                     }
            });

            // SO-16

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH will eine Stelle neu besetzen. Mit einer Bewerberin soll ein Einstellungsgespräch geführt werden.",
                Question = "Nach welcher der folgenden Eigenschaften darf eine Bewerberin in einem Einstellungsgespräch nicht gefragt werden?",
                AnswerHeader = "",
                Answers = new[] {
                     "Beruflicher Werdegang",
                     "Familienstand",
                     "Mitgliedschaft in einer Gewerkschaft",
                     "Krankenkassenzugehörigkeit",
                     "Alter"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Mitarbeiterin der Easter GmbH, Marina Meußling, ist erstmaliig erkrankt und langfristig arbeitsunfähig",
                Question = "Wie viele Wochen muss die Easter Gmbh den Lohn gemäß dem Entgeltfortzahlungsgesetz weiterzahlen.",
                AnswerHeader = "",
                Answers = new[] {
                     "6 Wochen",
                     "3 Wochen",
                     "4 Monate",
                     "12 Tage"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "In der Easter GmbH wurden verschiedene Sachverhalte durch betriebliche und tarifliche Vereinbarungen geregelt.",
                Question = "Welche der folgenden Sachverhalte können durch eine Betriebsvereinbarung geregelt werden?",
                AnswerHeader = "",
                Answers = new[] {
                     "Einführung einer Gleitzeitregelung für die Mitarbeiter der Easter GmbH",
                     "Die Anzahl der Urlaubstage",
                     "Die Höhe der Arbeitsengelte nach Gehaltsgruppe",
                     "Aufstellung des Urlaubsplans",
                     "Erhöhung der regelmäßigen täglichen Arbeitszeit auf 12 Stunden",
                     "Die Dauer der Entgeltfortzahlung im Krankheitsfall"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der IT-Solutions GmbH, einer Kundin der Easter GmbH, haben der Arbeitgeber und der Betriebsrat einen Sozialplan ausgearbeitet.",
                Question = "In welchem der folgenden Fälle ist ein Sozialplan auszuarbeiten?",
                AnswerHeader = "",
                Answers = new[] {
                     "Aussperrung",
                     "Betriebserweiterung",
                     "Massenentlassungen",
                     "Einführung von Sozialmaßnahmen",
                     "Kurzarbeit"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In der Wirtschaftsordnung der Bundesrepublik Deutschland werden die Arbeitgeber- und die Arbeitnehmerverbände als Sozialpartner bezeichnet.",
                Question = "Welches der folgenden Rechte steht den beiden Sozialpartnern zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Festlegung der beitragsmessenungsgrenzen in der Sozialversicherung",
                     "Abschluss von Tarifverträgen",
                     "Verkürzung der Kündigungsfristen bei Arbeitsverhältnissen",
                     "Verkürzung des Mindesturlaubes",
                     "Erlass von Prüfungsordnungen für anerkannte Ausbildungsberufe"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Interessen der Mitarbeiter werden in der Easter GmbH durch den gewählten Betriebsrat vertreten.",
                Question = "In welcher der folgenden Angelegenheiten hat der Betriebsrat laut Betriebsverfassungsgesetz ein Mitbestimmungsrecht?",
                AnswerHeader = "",
                Answers = new[] {
                     "Einführung einer Arbeitszeiterfassung",
                     "Eröffnung einer neuen Filiale",
                     "Einführung eines neuen Warenwirtschaftssystems",
                     "Einführung einer neuen Lagerhalle",
                     "Einstellung eines neuen Geschäftsführers"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH überträgt dem neuen Filialleiter Peter Müller Prokura.",
                Question = "Welche der folgenden Aussagen trifft auf Prokura zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Prokurist unterzeichnet Geschäftsbriefe mit i. V. Peter Müller.",
                     "Die Ereteilung der Prokura wird in das Handelsregister eingetragen.",
                     "Der Prokurist kann ohne besondere Vollmacht Grundstücke verkaufen.",
                     "Der Prokurist kann das Unternehmen veräußern.",
                     "Der Prokurist unterschreibt die jährliche Bilanz."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Im Rahmen der Tarifverhandlungen wird zwischen Lohn- und Gehaltstarif und dem normalerweise längerfristig geltenden Manteltarif unterschieden.",
                Question = "Welcher der folgenden Inhalte wird typischerweise in einem Lohn- und Gehaltstarif geregelt?",
                AnswerHeader = "",
                Answers = new[] {
                     "Kündigungsfristen",
                     "Tägliche und wöchentliche Arbeitszeit",
                     "Urlaubstage",
                     "Gehaltssätze für die einzelnen Gehaltsgruppen",
                     "Sonderleistungen"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Nach der Abschlussprüfung informieren Sie sich über Möglichkeiten der beruflichen Fortbildung.",
                Question = "Welcher der folgenden Sachverhalte ist ein Beispiel für eine berufliche Fortbildung?",
                AnswerHeader = "",
                Answers = new[] {
                     "Lars Ruschmeyer besucht nach dem Realschulabschluss (MSA) die Berufsfachschule für Kaufmännische Assistenten.",
                     "Ein Auszubildender der Easter GmbH nimmt in einer überbetrieblichen Ausbildungsstätte an einem Lehrganz zum Thema IT-Sicherheit teil.",
                     "Sie besuchen an der Volkshochschule einen Segelkurs.",
                     "Ein Auszubildender mit Abitur will nach Abschluss der Ausbildung studieren.",
                     "Die Mitarbeiterin Lena Hellmers nimmt nach der Ausbildung zur IT-System-Kauffrau an einem Fernlehrgang 'Business English' teil."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH ist gesetzlich verpflichtet, für die Mitarbeiter Einkommenssteuer abzuführen.",
                Question = "Welche der folgenden Aussagen trifft auf die Einkommenssteuer zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Die Einkommenssteuer steht ausschließlich dem Bund zu.",
                     "Die Einkommenssteuersätze steigen linear zum Einkommen.",
                     "Die Einkommenssteuer wird unabhängig vom Familienstand berechnet.",
                     "Verheiratete Mitarbeiter können die Steuerklasse III, IV oder V haben.",
                     "Die Einkommenssteuersätze sind in jedem Bundesland unterschiedlich."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Ein Mitarbeiter der Easter GmbH wird in Kürze Vater.",
                Question = "Welcher der folgenden Aussagen stimmt mit dem Bundeselterngeld- und Elternzeitgesetz (BEEG) überein?",
                AnswerHeader = "",
                Answers = new[] {
                     "Elternzeit kann nur dann in Anspruch genommen werden, wenn der Arbeitgeber zustimmt.",
                     "Elternzeit kann nur von Müttern in Anspruch genommen werden.",
                     "Elternzeit kann entweder nur vom Vater oder nur von der Mutter in Anspruch genommen werden.",
                     "Das Elterngeld ist in der Höhe begrenzt.",
                     "Elterngeld wird einheitlich und einkommensunabhängig gewährt."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Kunden der Easter GmbH sind sowohl öffentlich-rechtliche Unternehmen, die nach dem Kostendeckungsprinzip arbeiten, als auch erwerbswirtschaftliche Unternehmen, die gewinnorientiert arbeiten.",
                Question = "Welches der folgenden Unternehmen arbeitet nach dem Kostendeckungsprinzip?",
                AnswerHeader = "",
                Answers = new[] {
                     "SAP AG, Berlin",
                     "Microsoft GmbH",
                     "Stadtwerke Lübeck",
                     "Buchhandlung Hugendubel GmbH",
                     "Adobe Systems GmbH"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH verfolgt unterschiedliche Zielsetzungen. Einige Ziele lassen sich gut miteinander verbinden (komplementäre Ziele). Andere Ziele schließen sich jedoch gegenseitig aus (konkurrierende Ziele).",
                Question = "In welcher der folgenden Aussagen handelt es sich um komplementäre Ziele?",
                AnswerHeader = "",
                Answers = new[] {
                     "Verringerung von Risiken durch Währungsschwankungen und Erhöhung der Exporte in Nicht-EU-Ländern.",
                     "Reduzierung der Kosten und Erhöhung der Löhne.",
                     "Entlassung von Mitarbeitern und Reduzierung der Überstunden.",
                     "Abbau von Arbeitsplätzen und Outsourcing des Rechnungswesens.",
                     "Erhöhung der Sozialleistung und Seknung der Lohnnebenkosten."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH will mit der Cashsystems GmbH fusionieren. Die Cashsystems GmbH verliert ihre wirtschaftliche und rechtliche Selbstständigkeit.",
                Question = "Welche der folgenden Aussagen trifft auf eine Fusion zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Eine Fusion führt immer zu Preissenkungen.",
                     "Die Easter GmbH möchte ihre Marktanteile ausweiten.",
                     "Eine Fusion führt immer zur Sicherung der Arbeitsplätze.",
                     "Durch eine Fusion wird der Wettbewerb gefördert.",
                     "Durch eine Fusion werden alle Standorte gesichert."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Easter GmbH will ein Tochterunternehmen in der Rechtsform einer GmbH mit vorerst zehn Mitarbeitern gründen.",
                Question = "Welche der folgenden Vorschriften sind dabei zu beachten?",
                AnswerHeader = "",
                Answers = new[] {
                     "Als Firma muss eine Sachfirma gewählt werden.",
                     "Die Gründung kann allein durch die Easter GmbH erfolgen.",
                     "Das Stammkapital muss mindestens 25.000 EUR betragen.",
                     "Es muss ein Aufsichtsrat bestellt werden.",
                     "Die Easter GmbH haftet solidarisch für das Tochterunternehmen.",
                     "Die Gründung bedarf der Genehmigung des Kartellamtes."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In einem Arbeitstreffen analysieren Sie verschiedene Marktsituationen.",
                Question = "Welcher der folgenden Indikatoren weist auf einen Verkäufermarkt hin?",
                AnswerHeader = "",
                Answers = new[] {
                     "Auf dem Markt für USB-Sticks gibt es weniger Nachfrager als Anbieter.",
                     "Einem großen Angebot an Laptops steht ein relativ geringere Nachfrage gegenüber.",
                     "In der IT-Branche herrscht starker Wettbewerb.",
                     "Das Angebot an Laptops übersteigt die Nachfrage.",
                     "Die Nachfrage nach USB-Sticks ist größer als das Angebot."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Der 16-Jährige Auszubildende Peter Müller kauft einen Motorroller im Wert von 2.299,00 EUR.",
                Question = "Welche der folgenden Aussagen trifft auf dieses Rechtsgeschäft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Das Rechtsgeschäft ist nichtig.",
                     "Das Rechtsgeschäft ist anfechtbar.",
                     "Das Rechtsgeschäft ist bis zur Zustimmung der gesetzlichen Vertreter schwebend unwirksam.",
                     "Das Rechtsgeschäft ist uneingeschränkt gültig.",
                     "Peter Müller ist nicht rechtsfähig."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Heinz Müller und Petra Schmitz, die mehrere Jahre in der Easter GmbH beschäftigt waren, wollen sich mit einem IT-Unternehmen selbstsändig machen." +
                                 "\nDie finanzierende Bank erwartet von den Existenzgründen die Vorlage eines Businessplans.",
                Question = "Welche der folgenden Aussagen über einen Businessplan trifft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Im Businessplan werden die strategischen Ziele der geplanten Unternehmungen festgelegt.",
                     "Der Businessplan wird von der IHK des Kammerbezirks ausgestellt, in dem das Unternehmen gegründet wird.",
                     "Der Businessplan wird im Handelsregister hinterlegt.",
                     "Ein Businessplan muss nur bei der Gründung von Kapitalgesellschaften erstellt werden.",
                     "Ein Businessplan ist nur bei der Aufnahme von Darlehen notwendig."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Easter GmbH handelt mit Waren, die in weltweiter Arbeitsteilung hergestellt werden.",
                Question = "Welche der folgenden Aussagen trifft auf die weltweite Arbeitsteilung zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Durch die weltweite Arbeitsteilung in allen Ländern gleich hohe soziale und ökologische Standards garantiert.",
                     "Die Umweltbelastung durch den Transport der Waren nimmt ab.",
                     "Auf dem weltweiten Arbeitsmarkt herrscht eine allgemeine Arbeitnehmerfreizügigkeit.",
                     "Durch die weltweite Arbeitsteilung nimmt die Menge der transportierten Waren stetig zu.",
                     "Die Produktion erfolgt jeweils in den Ländern mit den ökologisch besten Standards."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Volkswirtschaft der Bundesrepublik Deutschland profitiert von der Globalisierung.",
                Question = "Welche der folgenden Maßnahmen fördert die Globalisierung?",
                AnswerHeader = "",
                Answers = new[] {
                     "Die Erhöhung der Importzölle.",
                     "Die Erhöhung von Steuern für Transportdienstleistungen.",
                     "Die Erhöhung von Exportschranken.",
                     "Ein deutsches Unternehmen eröffnet Niederlassungen in Asien und Amerika.",
                     "Ein deutsches Unternehmen zentralisiert die Fertigung in Deutschland."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die soziale Marktwirtschaft ist in Deutschland ein gesellschafts- und wirtschaftspolitisches Leitbild.",
                Question = "Welche der folgenden Aussagen zur sozialen Marktwirtschaft ist zutreffend?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Staat fördert Monopole und Kartelle, um einen Leistungswettbewerb zu verhindern.",
                     "Der Staat greift regulierend in Märkte ein, indem er für Waren Mindest- und Höchstpreise sowie Angebotsmengen festsetzt.",
                     "Durch sozialen Ausgleich und solidarische Hilfe soll eine Chancengerechtigkeit erreicht werden.",
                     "Durch die Gesetzgebung werden alle Wettbewershemmnisse vermieden, sodass auf den Märkten eine vollständige Konkurrenz erreicht wird.",
                     "Alle von Insolvenz bedrohten Unternehmen werden auf Antrag durch staatliche Subventionen gestützt."
                     }
            });

            // SO-17

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Für die Entwicklung des neuen Geschäftsfeldes Clouddienste plant Ecotec GmbH die Einstellung von Mitarbeitern." +
                                 "\nIn den Arbeitsverträgen der neuen Mitarbeiter soll eine regelmäßige tägliche Arbeitszeit von zehn Stunden vereinbart werden." +
                                 "\nDie Ecotec GmbH arbeitet fünf Tage in der Woche von Montag bis Freitag.",
                Question = "Welche der folgenden Aussagen zur regelmäßigen täglichen Arbeitszeit trifft zu?",
                AnswerHeader = "Die Vereinbarung ...",
                Answers = new[] {
                     "ist zulässig, wenn sie tarifvertaglich vereinbart wurde.",
                     "ist zulässig, wenn der Betriebsrat mit der Geschäftsleitung eine entsprechende Betriebsvereinbarung abschließt.",
                     "ist zulässig, weil die tägliche Arbeitszeit keiner gesetzlichen Beschränkung unterliegt.",
                     "ist zulässig, weil in der Ecotec GmbH samstags nicht gearbeitet wird.",
                     "ist nicht zulässig, weil lauf Arbeitszeitgesetz eine zehnstündige Arbeitszeit nur in Ausnahmefällen erlaubt ist."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Für die neuen Mitarbeiter soll in den Arbeitsverträgen eine Probezeit von sechs Monaten vereinbart werden.",
                Question = "Welche der folgenden Aussagen trifft auf die vereinbarte Probezeit zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Arbeitgeber kann das Arbeitsverhältnis während der Probezeit nicht kündigen.",
                     "Das Arbeitsverhältnis kann während der Probezeit mit einer Frist von zwei Wochen gekündigt werden.",
                     "Der Arbeitgeber kann das Arbeitsverhältnis nur aus wichtigem Grund kündigen.",
                     "Während der Probezeit kann nur der Arbeitnehmer das Arbeitsverhältnis kündigen.",
                     "Die Probezeit darf maximal drei Monate betragen."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 3,
                IsMultipleChoice = true,
                QuestionHeader = "Die Geschäftsleitung der Ecotec GmbH arbeitet mit dem Betriebsrat zusammen.",
                Question = "in welchen der folgenden Angelegenheiten hat der Betriebsrat laut Betriebsverfassungsgesetz ein Mitbestimmungsrecht?",
                AnswerHeader = "",
                Answers = new[] {
                     "Einführung eines Personalbeurteilungssystems",
                     "Planung des Personalbedarfs",
                     "Erstellung eines Sozialplans",
                     "Einführung neuer Arbeitsverfahren",
                     "Errichten einer neuen Lagerhalle",
                     "Gründung einer Filiale",
                     "Umwandlung der Rechtsform",
                     "Erstellung des Urlaubsplans"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Der Betriebsrat der Ecotec GmbH lädt zur vierteljährlichen Betriebsversammlung ein.",
                Question = "Welcher der folgenden Personenkreise ist berechtigt, an der Betriebsversammlung teilzunehmen?",
                AnswerHeader = "",
                Answers = new[] {
                     "Nur die gewerkschaftlich organisierten Mitarbeiter",
                     "Nur die Betriebsratmitglieder und die Gewerkschaftsvertreter",
                     "Nur die Vollzeitmitarbeiter und die Führungskräfte",
                     "Nur die Vollzeitmitarbeiter und die Auszubildenden",
                     "Alle Arbeitnehmer des Unternehmens"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In Tarifverhandlungen wird zwischen Lohn- und Gehaltstarifvertrag und dem Manteltarifvertrag unterschieden.",
                Question = "Welche der folgenden Regelungen wird im Manteltarifvertrag vereinbart?",
                AnswerHeader = "",
                Answers = new[] {
                     "Urlaubstage",
                     "Gleitzeitregelungen",
                     "Gehaltssätze für die einzelnen Gehaltsgruppen",
                     "Ausbildungsvergütung",
                     "Sonderleistungen"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Ecotec GmbH ist an Vereinbarungen gebunden, die die Sozialpartner miteinander vereinbar haben.",
                Question = "Welche der folgenden Einrichtungen wird zu den Sozialpartnern gerechnet?",
                AnswerHeader = "",
                Answers = new[] {
                     "Deutsche Sozialversicherung",
                     "Arbeitnehmerverbände",
                     "Bundesagentur für Arbeit",
                     "Bundesministerium für Arbeit und Soziales",
                     "Industrie- und Handelskammern"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Mitarbeiter der Ecotec GmbH sind in der gesetzlichen Krankenversicherung (GKV) pflichtversichert.",
                Question = "Welche der folgenden Aussagen trifft auf die gesetzliche Krankenversicherung zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Die Versicherungspflichtgrenze gibt an, ab welchem Jahresbruttoentgelt ein Arbeitnehmer in der GKV versichert sein muss.",
                     "Ein Wechsel der Krankenkasse ist nur mit Zustimmung des Arbeitgebers möglich.",
                     "Der Beitragssatz wird vom Bundesministerium für Gesundheit festgelegt.",
                     "Der Beitrag wird vom Nettolohn berechnet.",
                     "Auf den Teil des Bruttolohns, der die Beitragsermessungsgrenze übertsteigt, wird kein Beitrag erhoben."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Arbeitnehmer der Ecotec GmbH sind gesetzlich unfallversichert.",
                Question = "Welche der folgenden Fälle werden von der gesetzlichen Unfallversicherung abgedeckt?",
                AnswerHeader = "",
                Answers = new[] {
                     "Die Mitarbeiterin Petra Karst rutscht im Lager aus und verstaucht sich den Fuß.",
                     "Der Mitarbeiter Yannick Weber ist wegen einer Grippeerkrankung arbeitsunfähig.",
                     "Der Mitarbeiter Tim Schneider stürzt im heimischen Garten und bricht sich ein Bein.",
                     "Die Auszubildende Sophie Schmitz rutscht auf dem direkten Weg zur Arbeit aus und zieht sich eine Bänderdehnung zu.",
                     "Das Kind der Mitarbeiterin Sarah Buchholz ist an Masern erkrankt und muss zu Hause von der Mutter betreut werden.",
                     "Der Mitarbeiter Marco Bode sucht seinen Augenarzt auf, weil seine Sehkraft sich verschlechtert hat."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Zwei 25-Jährige Mitarbeiter der Ecotec GmbH diskutieren in der Mittagspause über die Möglichkeiten der gesetzlichen Rentenversicherung und die Möglichkeit der privaten Altersvorsorge.",
                Question = "Welches der folgenden Argumente trifft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Eine private Altersvorsorge ist nicht notwendig, weil die gesetzliche Rentenversicherung auf jeden Fall ausreichen wird.",
                     "Der demografische Wandel sorgt auch in Zukunft für genug Beitragszahler, weshalb das Rentenniveau der gesetzlichen Rentenversicherung steigt.",
                     "Eine private Altersvorsorge ist sinnvoll, weil das Rentenniveau in der gesetzlichen Rentenversicherung sinken wird.",
                     "Eine private Altersvorsorge lohnt sich nicht, weil das Zinsneveau zu niedrig ist.",
                     "Eine private Altersvorsorge ist nur notwendig, wenn die Inflationsrate steigt."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Subsidiarität und Solidarität sind gesellschaftpolitische Prinzipien, die in der Bundesrepublik Deutschland angewendet werden.",
                Question = "Welcher der folgenden Sachverhalte entspricht dem Prinzip der Solidarität?",
                AnswerHeader = "",
                Answers = new[] {
                     "Aufgrund von Gleichbehandlungsgrundsätzen streicht der Staat Transferleistungen.",
                     "Die Steuern auf Kapitalerträge werden gesenkt.",
                     "Die Feibeträge bei der Erbschaftssteuer werden erhöht.",
                     "Eine 18-jährige Berufsschülerin ist beitragsfrei bei ihren Eltern in der Kranken- und Pflegeversicherung mitversichert.",
                     "Der Staat gestattet Bürgern, die über mehr als das Doppelte des durchschnittlichen Haushaltseinkommens verfügen, einen Teil des Einkommens steuerfrei im Ausland zu hinterlegen."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In Deutschland gibt es neben privaten Betrieben auch öffenntlich-rechtliche Betriebe.",
                Question = "Welches der folgenden Ziele trifft auf einen öffentlich-rechtlichen Betrieb zu?",
                AnswerHeader = "Ein öffentlichlich-rechtlicher Betrieb verfolgt primär das Ziel ...",
                Answers = new[] {
                     "der Gewinnmaximierung.",
                     "der Kostenminimierung.",
                     "der bestmöglichen Versorgung der Bevölkerung mit bestimmten Dienstleistungen oder Sachgütern (z.B. mit Wasser).",
                     "der Umsatzsteigerung.",
                     "der Dividendenausschüttung."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Nachfrage der Kunden (Konsumenten) der Ecotec GmbH hängt von verschiedenen Faktoren ab.",
                Question = "Welche der folgenden Aussagen trifft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Der Bedarf der Konsumenten ist gleich der Menge der Bedürfnisse.",
                     "Der Bedarf der Konsumenten ist abhängig von der Kaufkraft.",
                     "Die Nachfrage der Konsumenten ist abhängig vom Angebot.",
                     "Die Bedürfnisse der Konsumenten entsprechen dem Angebot.",
                     "Die Bedürfnisse der Konsumenten entsprechen deren Nachfrage."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die 16-jährige Laura Peters verfügt über eine monatliche Ausbildungsvergütung von 695,00 EUR. Sie ist leidenschaftlich PC-Gamerin und bestellt bei der Ecotec GmbH einen High-End-PC zum Preis von 4.999,00 EUR.",
                Question = "Welche der folgenden Aussagen zu diesem Rechtsgeschäft trifft zu?",
                AnswerHeader = "",
                Answers = new[] {
                     "Mit Beginn der Ausbildung ist Frau Peters unbeschränkt geschäftsfähig.",
                     "Das Rechtsgeschäft ist bis zur Zustimmung der gesetzlichen Vertreter schwebend unwirksam.",
                     "Das Rechtsgeschäft ist gültig. weil Frau Peters unbeschränkt rechtsfähig ist.",
                     "Auszubildende sind generell geschäftsunfähig.",
                     "Rechtsgeschäfte beschränkt Geschäftsfähiger über 1.000 EUR bedürfen der Zustimmung des Familiengerichts."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Ecotec GmbH hat einen großen Kundenstamm mit privaten als auch gewerblichen Kunden.",
                Question = "Welche der folgenden Kunden sind juristische Personen?",
                AnswerHeader = "",
                Answers = new[] {
                     "Städtische Werke Nürnberg GmbH",
                     "Prokurist Daniel Kleiber",
                     "Rechtsanwältin Sophie Kropp",
                     "Novobyte AG",
                     "Wirtschaftsprüfer Josef Ohlert",
                     "Fachinformatikerin Carolin Schult"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Ecotec GmbH überträgt der Mitarbeiterin Meike Schipp Allgemeine Handlungsvollmacht.",
                Question = "Mit welcher der folgenden Unterschriften muss Frau Schipp einen Vertrag unterzeichnen?",
                AnswerHeader = "Ecotec GmbH ...",
                Answers = new[] {
                     "Schipp",
                     "Meike Schipp",
                     "ppa. Schipp",
                     "i. V. Schipp",
                     "a. H. Schipp"
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die Arbeitsleistung der Ecotec GmbH werden von verschiedenen Wirtschaftseinheiten erbracht.",
                Question = "In welchem der folgenden Fälle handelt es sich um eine betriebliche Arbeitsteilung (Arbeitszerlegung)?",
                AnswerHeader = "Ecotec GmbH ...",
                Answers = new[] {
                     "gliedert einen Schritt des Leistungsprozesses an die Byte GmbH aus.",
                     "lässt von einem Mitarbeiter ein Produkt aus Komponenten zusammebauen, die von verschiedenen externen Unternehmen hergestellt wurden.",
                     "organisiert mehrere Prozesse als 'supply chain', in denen Lieferanten, Abteilungen der Ecotec GmbH und Kunden miteinander vernetzt sind.",
                     "eröffnet eine Filiale in Niedersachsen, die in allen Geschäftsfeldern selbstständig operieren soll.",
                     "produziert ein Produkt in mehrere Arbeitsschritten, die von mehreren Arbeitskräften ausgeführt werden."
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "",
                Question = "",
                AnswerHeader = "",
                Answers = new[] {
                     "",
                     ""
                     }
            });















            return WisoList;
        }
    }
}
