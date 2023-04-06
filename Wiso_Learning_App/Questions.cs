namespace Wiso_Learning_App
{
    public class Questions
    {
        public List<Wiso_Q> LoadQuestions()
        {
            var WisoList = new List<Wiso_Q>();

            // SO-13

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 2,
                IsMultipleChoice = true,
                QuestionHeader = "Die Pflichten von Auszubildenden sind im Berufsbildungsgesetz (BBIG) und in der Verordnung über die Berufsausbildung geregelt.",
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                QuestionHeader = "Die WÄRMGUT GmbH lässt eine neue Fertigungsstraße installieren. An einer Tür sehen Sie das abgebildete Warnzeichen:",
                PicturePath = "2000px-DIN_4844-2_Warnung_vor_Laserstrahl_D-W010.svg.png",
                Question = "Vor welcher der folgenden Gefahren warnt dieses Zeichen?",
                AnswerHeader = "",
                Answers = new[] {"Elektromagnetische Felder",
                     "Laserstrahl",
                     "Radioaktive Stoffe",
                     "Explosive Stoffe",
                     "Rotierende Maschinenteile"}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "Die WÄRMGUT GmbH hat für die Sicherheit ihrer Mitarbeiter am Arbeitsplatz zu sorgen.",
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                QuestionHeader = "Für das aktuelle Smartphone des Marktführers wird ein Nachfolgemodell für das IV. Quartal angekündigt." +
                           "Folgende Grafik zur Marktsituation des aktuellen Modells liegt vor.",
                PicturePath = "20",
                Question = "Welche der folgenden Aussagen können Sie ohne zusätzliche Informationen aus der Grafik ableiten?",
                AnswerHeader = "Im III. Quartal ...",
                Answers = new[] {"wurden die Werbemaßnahmen erhöht",
                     "wurde das Angebot vergrößert.",
                     "wurde kein MArktgleichgewichtspreis erreicht.",
                     "sinkt der Marktpreis.",
                     "wirkte sich die höhere Nachfrage nach einem Komplementärprodukt aus."}
            });

            WisoList.Add(new Wiso_Q()
            {
                Id = WisoList.Count + 1,
                Choices = 1,
                IsMultipleChoice = false,
                QuestionHeader = "In einem Arbeitstreffen analysieren Sie verschiedene Marktsituationen.",
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                QuestionHeader = "",
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
                PicturePath = "",
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
