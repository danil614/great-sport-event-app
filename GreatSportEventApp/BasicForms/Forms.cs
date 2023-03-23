using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SimpleForms;
using GreatSportEventApp.SportEventForms;
using GreatSportEventApp.TeamForms;
using GreatSportEventApp.TicketForms;
using GreatSportEventApp.UserForms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.BasicForms
{
    public static class Forms
    {
        /// <summary>
        /// Открыть форму мероприятий и участников.
        /// </summary>
        public static void OpenEventsParticipantsForm(DockPanel dockPanel)
        {
            EventsParticipantsForm eventsParticipantsForm = new();
            eventsParticipantsForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму мест.
        /// </summary>
        public static void OpenLocationsForm(DockPanel dockPanel)
        {
            ListLocationsForm locationsForm = new(false);
            locationsForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму о программе.
        /// </summary>
        public static void OpenAboutForm()
        {
            AboutForm aboutForm = new();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Открыть форму городов.
        /// </summary>
        public static void OpenCitiesForm(DockPanel dockPanel)
        {
            CitiesForm citiesForm = new();
            citiesForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму должностей.
        /// </summary>
        public static void OpenPositionsForm(DockPanel dockPanel)
        {
            PositionsForm positionsForm = new();
            positionsForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму команд.
        /// </summary>
        public static void OpenTeamsForm(DockPanel dockPanel)
        {
            ListTeamsForm teamsForm = new(false);
            teamsForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму зрителей.
        /// </summary>
        public static void OpenViewersForm(DockPanel dockPanel)
        {
            ListViewersForm viewersForm = new(false);
            viewersForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму билетов.
        /// </summary>
        public static void OpenTicketsForm(DockPanel dockPanel)
        {
            ListTicketsForm ticketsForm = new(false);
            ticketsForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму сотрудников.
        /// </summary>
        public static void OpenEmployeesForm(DockPanel dockPanel)
        {
            ListEmployeesForm employeesForm = new(false);
            employeesForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму спортсменов.
        /// </summary>
        public static void OpenAthletesForm(DockPanel dockPanel)
        {
            ListAthletesForm athletesForm = new(false);
            athletesForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открыть форму пользователей.
        /// </summary>
        public static void OpenUsersForm(DockPanel dockPanel)
        {
            ListUsersForm usersForm = new(false);
            usersForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открывает форму типов.
        /// </summary>
        public static void OpenTypesForm(DockPanel dockPanel)
        {
            TypesForm typesForm = new();
            typesForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открывает форму мероприятий и сотрудников.
        /// </summary>
        public static void OpenEventsEmployeesForm(DockPanel dockPanel)
        {
            EventsEmployeesForm employeesForm = new();
            employeesForm.Show(dockPanel, DockState.Document);
        }

        /// <summary>
        /// Открывает форму спортивных мероприятий.
        /// </summary>
        public static void OpenSportEventsForm(DockPanel dockPanel)
        {
            ListSportEventsForm sportEventsForm = new(false);
            sportEventsForm.Show(dockPanel, DockState.Document);
        }
    }
}
