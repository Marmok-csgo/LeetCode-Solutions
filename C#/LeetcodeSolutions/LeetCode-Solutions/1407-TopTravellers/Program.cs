// select users.name, ifnull(sum(rides.distance),0) as travelled_distance
// from users left join rides
// on users.id = rides.user_id
// group by user_id
// order by travelled_distance desc, name asc