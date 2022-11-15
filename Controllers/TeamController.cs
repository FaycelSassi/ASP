using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        static public List<Team> teams= new List<Team>{
            new Team{Id=1,Name="Mercedes",Points=165,PrincipalName="Toto Wolf"},
            new Team{Id=2,Name="Ferrari",Points=175,PrincipalName="Binotto"}
        };
         [HttpGet]
        public ActionResult<List<Team>> GetAllTeams(){
        
            return Ok(teams);
            
        }
        [HttpGet("{id}")]
        public ActionResult<List<Team>> GetTeam(int id){
            var team=teams.Find(x=>x.Id==id);
                if (team==null){
                    return NotFound("Team unexistant");
                }
            return Ok(team);  
        }
        [HttpPost]
        public ActionResult<List<Team>> CreateTeam(Team team){
             if (team==null){
                    return NotFound("Team unexistant");
                }
                teams.Add(team);
            return Ok(teams);  
        }
        [HttpPut]
        public ActionResult<List<Team>> UpdateTeam(Team upteam){
            var team=teams.Find(x=>x.Id==upteam.Id);
             if (team==null){
                    return NotFound("Team unexistant");
                }
                team.Name=upteam.Name;
                team.PrincipalName=upteam.PrincipalName;
                team.Points=upteam.Points;
            return Ok(team);  
        }
        [HttpDelete]
        public ActionResult<List<Team>> DeleteTeam(int id){
            var team=teams.Find(x=>x.Id==id);
             if (team==null){
                    return NotFound("Team unexistant");
                }
                teams.Remove(team);
            return Ok(team);  
        }
    }
}