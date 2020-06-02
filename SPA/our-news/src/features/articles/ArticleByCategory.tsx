import React, {useState, useEffect, Fragment} from 'react'
import { Grid,Card, Item, Image, Icon, Button, Divider, Label, List } from 'semantic-ui-react'
import agent from '../../app/api/agent'
import { IArticle } from '../../app/models/article';
import moment from 'moment'

const ArticleByCategory = () => {
    const [articlesScience, setArticlesScience] = useState<IArticle[]>([]);
    const [scienceLatest, setScienceLatest] = useState<IArticle>();

    useEffect(() => {
  
        agent.Articles.listByCategory("science", 4).then(response => {
            setScienceLatest(response.shift()) 
            setArticlesScience(response);            
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
                        SCIENCE
                    </Label>
                    <Divider />
                    </List.Item>
                </List>
                </Grid.Column>                
            </Grid.Row>  
           <Grid.Row columns={2}>  
           {scienceLatest &&           
               <Grid.Column width={7}>  
                
                    <Card fluid style={{overflowWrap: 'break-word'}}>
                        <Image src={scienceLatest.mainPhoto} wrapped ui={false} />
                        <Card.Content extra>                            
                                <Icon name='user' />{scienceLatest.author}
                                <Icon name='clock' style={{marginLeft: "10%"}}/>
                                        {moment("2020-05-25").format("DD/MM/YYYY")}
                        </Card.Content>
                        <Card.Content>                        
                            <Card.Header style={{color: "#4a4949"}}>
                                {scienceLatest.title}
                            
                            </Card.Header>
                            <Card.Description>
                                {scienceLatest.description}
                            </Card.Description>     
                            <Card.Meta>
                                <Button basic color='red' style={{marginTop: "1em"}}>
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
                        articlesScience.length > 0 &&
                        articlesScience.map((data) => (
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

export default ArticleByCategory
