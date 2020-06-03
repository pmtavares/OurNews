import React, {useState, useEffect, Fragment} from 'react'
import { Grid,Card, Item, Image, Icon, Button, Divider, Label, List } from 'semantic-ui-react'
import agent from '../../app/api/agent'
import { IArticle } from '../../app/models/article';
import moment from 'moment'

const TechnologyArticles = () => {
    const [articlesTechnology, setArticlesTechnology] = useState<IArticle[]>([]);
    const [technologyLatest, setTechnologyLatest] = useState<IArticle>();

    useEffect(() => {
  
        agent.Articles.listByCategory("technology", 4).then(response => {
            setTechnologyLatest(response.shift()) 
            setArticlesTechnology(response);            
        });
        
      
        return () => {
          
        }
      }, [])
    return (
        <Grid>
            <Grid.Row>
                <Grid.Column>
                <List>
                    <List.Item>
                    <Label color='red' horizontal>
                        TECHNOLOGY
                    </Label>
                    <Divider />
                    </List.Item>
                </List>
                </Grid.Column>                
            </Grid.Row>  
           <Grid.Row columns={2}>  
           {technologyLatest &&           
               <Grid.Column width={7}>  
                
                    <Card fluid style={{overflowWrap: 'break-word'}}>
                        <Image src={technologyLatest.mainPhoto} wrapped ui={false} />
                        <Card.Content extra>                            
                                <Icon name='user' />{technologyLatest.author}
                                <Icon name='clock' style={{marginLeft: "10%"}}/>
                                        {moment("2020-05-25").format("DD/MM/YYYY")}
                        </Card.Content>
                        <Card.Content>                        
                            <Card.Header style={{color: "#4a4949"}}>
                                {technologyLatest.title}
                            
                            </Card.Header>
                            <Card.Description>
                                {technologyLatest.description}
                            </Card.Description>     
                            <Card.Meta>
                                <Button color='orange' style={{marginTop: "1em"}}>
                                    Read more
                                </Button>
                            </Card.Meta>               
                        </Card.Content>              
                    </Card>    
                    </Grid.Column>
                }                 
           
               
               <Grid.Column>
                <Item.Group>
                    {
                        articlesTechnology.length > 0 &&
                        articlesTechnology.map((data) => (
                        <Fragment key={data.id}>
                            <Item >                   
                                <Item.Content>
                                    <Item.Meta>
                                        {moment(data.datePublished).format("DD MMM YYYY")}
                                    </Item.Meta>
                                    <Item.Header as='a' style={{marginTop: "0.4em", marginBottom: "1em"}}>{data.title}</Item.Header>                        
                                </Item.Content>                                
                            </Item>  
                            <Divider />                  
                        </Fragment>
                        ))
                    }
                        
                    </Item.Group>
               </Grid.Column>
           </Grid.Row> 
        </Grid>
    )
}

export default TechnologyArticles
