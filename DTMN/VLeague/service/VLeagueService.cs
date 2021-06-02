using System;
using System.Collections.Generic;
using DTMN.VLeague.entity;
using VLeague.model;
using VLeague.helper;

namespace VLeague.service
{
    public class VLeagueService
    {
        private List<FootballTeam> _listTeam = FootballTeam.FootballTeamsList;
        private List<Schedule> _listSchedules = Schedule.ListSchedules;
        private VLeagueModel _model = new VLeagueModel();
        public void CreateTeam(FootballTeam team)
        {
            _model.CreateTeam(team);
        }     
        public void UpdateTeam(FootballTeam team)
        {
            for (int i = 0; i < _listTeam.Count; i++)
            {
                FootballTeam teamCheck = _listTeam[i];
                if (teamCheck.MaDoi == team.MaDoi)
                {
                    _listTeam[i] = team;
                }
            }   
        }

        public void CreateSchedule(Schedule schedule)
        {
            _model.CreateSchedule(schedule);
        }
        
        public List<FootballTeam> ListTeam()
        {
            return _model.ListTeam();
        }
    }
}